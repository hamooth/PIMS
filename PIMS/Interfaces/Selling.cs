using PIMS.Servies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;

namespace PIMS.Interfaces
{
    public partial class SellingForm : Form
    {
        private Dictionary<string, double> productsDictionary = new Dictionary<string, double>();

        public SellingForm()
        {
            InitializeComponent();

            Load += SellingForm_Load;

            timeTimer.Start();

            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            

            imgRestore.BringToFront();

            comboBox_Search.SelectedIndexChanged += ComboBox_Search_SelectedIndexChanged1;
            txtDiscount.TextChanged += TxtDiscount_TextChanged;
            txtPainMoney.TextChanged += TxtPainMoney_TextChanged;
        }

        private void ComboBox_Search_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string selectedItem = comboBox_Search.SelectedItem.ToString();
            if (productsDictionary.ContainsKey(selectedItem))
            {
                comboBox_price.Items.Clear();
                comboBox_price.Items.Add(productsDictionary[selectedItem]);
                comboBox_price.SelectedIndex = 0; 

                
                GetAvailableQuantity(selectedItem);
            }
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }

     
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int tree, int four);

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void imgClose_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult close;
            close = MessageBox.Show("Do you want to Close?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (close == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void imgMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            imgRestore.BringToFront();
        }

        private void imgRestore_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            imgMaximize.BringToFront();
        }

        private void imgMinimize_MouseClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseEnter(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.FromArgb(20, 20, 90);
        }

        private void pnlHeader_MouseLeave(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.MidnightBlue;
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTimeSale.Text = dateTime.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (sellingGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in sellingGridView.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == comboBox_Search.Text &&
                        Convert.ToString(row.Cells[1].Value) == comboBox_price.Text)
                    {
                        row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    sellingGridView.Rows.Add(comboBox_Search.Text, comboBox_price.Text, 1);
                }
            }
            else
            {
                sellingGridView.Rows.Add(comboBox_Search.Text, comboBox_price.Text, 1);
            }

            UpdateAmounts();
            UpdateTotalAmount();
            UpdateTotalQuantity();
            UpdateGrandTotal();

           
            GetAvailableQuantity(comboBox_Search.Text);

            
        }

        void ClearAll()
        {
            comboBox_Search.SelectedIndex = 0;
            comboBox_price.SelectedIndex = 0;
            txtSubTtl.Clear();
            txtDiscount.Clear();
            txtGrandTtl.Clear();






        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (chkReciept.Checked)
            {
                string pdfPath = GeneratePdfReceipt();
                ShowPdf(pdfPath);
            }
        }

        private bool itemsLoaded = false;
        private object dataService;

        private void LoadComboBoxData()
        {
            if (!itemsLoaded)
            {
                var dataService = new AddnewMedchin_servies();

                var products = dataService.ListAll()?.Select(x => new { x.Itemname, x.Sallingprice });

                if (products != null && products.Any())
                {
                    foreach (var product in products)
                    {
                        comboBox_Search.Items.Add(product.Itemname);
                        if (!productsDictionary.ContainsKey(product.Itemname))
                        {
                            productsDictionary.Add(product.Itemname, product.Sallingprice);
                        }
                    }
                    itemsLoaded = true;
                }
                else
                {
                    MessageBox.Show("No products found. Please try again.", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox_Search.Show();
                }
            }
        }

        private void ComboBox_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox_Search.SelectedItem.ToString();
            if (productsDictionary.ContainsKey(selectedItem))
            {
                comboBox_price.Items.Clear();
                comboBox_price.Items.Add(productsDictionary[selectedItem]);
                comboBox_price.SelectedIndex = 0; 
            }
        }

        private void UpdateAmounts()
        {
            foreach (DataGridViewRow row in sellingGridView.Rows)
            {
                if (sellingGridView.Columns["tAmount"] != null && sellingGridView.Columns["TPrice"] != null && sellingGridView.Columns["tQty"] != null)
                {
                    int amountColumnIndex = sellingGridView.Columns["tAmount"].Index;
                    int priceColumnIndex = sellingGridView.Columns["TPrice"].Index;
                    int qtyColumnIndex = sellingGridView.Columns["tQty"].Index;

                    if (row.Cells[priceColumnIndex].Value != null && row.Cells[qtyColumnIndex].Value != null)
                    {
                        double price = Convert.ToDouble(row.Cells[priceColumnIndex].Value);
                        double qty = Convert.ToDouble(row.Cells[qtyColumnIndex].Value);
                        row.Cells[amountColumnIndex].Value = price * qty;
                    }
                }
                else
                {
                    MessageBox.Show("One or more required columns are missing in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void UpdateTotalAmount()
        {
            double totalAmount = 0.0;

            foreach (DataGridViewRow row in sellingGridView.Rows)
            {
                if (row.Cells["tAmount"] != null && row.Cells["tAmount"].Value != null)
                {
                    totalAmount += Convert.ToDouble(row.Cells["tAmount"].Value);
                }
            }

            txtSubTtl.Text = totalAmount.ToString("F2");
        }

        private void UpdateTotalQuantity()
        {
            double totalQuantity = 0.0;

            foreach (DataGridViewRow row in sellingGridView.Rows)
            {
                if (row.Cells["tQty"] != null && row.Cells["tQty"].Value != null)
                {
                    totalQuantity += Convert.ToDouble(row.Cells["tQty"].Value);
                }
            }

            lblItemQty.Text = totalQuantity.ToString("F2");
        }

        private void UpdateGrandTotal()
        {
            if (double.TryParse(txtSubTtl.Text, out double subtotal))
            {
                double discount = 0.0;
                if (double.TryParse(txtDiscount.Text, out double parsedDiscount))
                {
                    discount = (parsedDiscount / 100) * subtotal;
                }

                double grandTotal = subtotal - discount;

                double paidAmount = 0.0;
                if (double.TryParse(txtPainMoney.Text, out double parsedPaidAmount))
                {
                    paidAmount = parsedPaidAmount;
                }

                double remainingAmount = grandTotal - paidAmount;

                txtGrandTtl.Text = grandTotal.ToString("F2");
                label11.Text = grandTotal.ToString("F2");
                label13.Text = remainingAmount.ToString("F2"); 

                lblTtl.Text = grandTotal.ToString("F2"); 
            }
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateGrandTotal();
        }

        private void TxtPainMoney_TextChanged(object sender, EventArgs e)
        {
            UpdateGrandTotal();
        }

        private string GeneratePdfReceipt()
        {
            Document document = new Document();
            string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Receipt.pdf");

            try
            {
                PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
                document.Open();

                
                document.Add(new Paragraph("Receipt"));
                document.Add(new Paragraph(" ")); 

                
                document.Add(new Paragraph("Date: " + DateTime.Now.ToString("MM/dd/yyyy")));
                document.Add(new Paragraph(" ")); 

                
                PdfPTable table = new PdfPTable(3);
                table.AddCell("Product");
                table.AddCell("Unit Price");
                table.AddCell("Quantity");

                foreach (DataGridViewRow row in sellingGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        table.AddCell(row.Cells[0].Value.ToString());
                        table.AddCell(row.Cells[1].Value.ToString());
                        table.AddCell(row.Cells[2].Value.ToString());
                    }
                }
                document.Add(table);

                // Add totals
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("Subtotal: " + txtSubTtl.Text));
                document.Add(new Paragraph("Discount: " + txtDiscount.Text + "%"));
                document.Add(new Paragraph("Grand Total: " + txtGrandTtl.Text));
                document.Add(new Paragraph("Paid Amount: " + txtPainMoney.Text));
                document.Add(new Paragraph("Remaining Amount: " + label11.Text));

                MessageBox.Show("Receipt generated successfully!", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document.Close();
            }

            return pdfPath;
        }

        private void ShowPdf(string pdfPath)
        {
            try
            {
                if (File.Exists(pdfPath))
                {
                    Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("PDF file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTtl_Click(object sender, EventArgs e)
        {

        }

        public int GetAvailableQuantity(string selectedItem)
        {
            int availableQuantity = -1; 

            try
            {
                
                AddnewMedchin_servies dataService = new AddnewMedchin_servies();

               
                var product = dataService.ListAll()?.FirstOrDefault(x => x.Itemname == selectedItem);

                if (product != null)
                {
                    availableQuantity = product.Itemquantity; 
                }
                else
                {
                    MessageBox.Show("Selected product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error retrieving available quantity: " + ex.Message);
            }

            
            if (availableQuantity >= 0)
            {
                lblAvailableQty.Text = availableQuantity.ToString(); 
            }
            else
            {
                lblAvailableQty.Text = "N/A"; 
            }

            return availableQuantity; 
        }

        private void comboBox_Search_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
