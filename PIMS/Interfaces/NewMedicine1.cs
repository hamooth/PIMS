using PIMS.Servies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Interfaces
{
    public partial class NewMedicine1 : Form
    {
        public NewMedicine1()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
        }

        //Custom drag bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int tree, int four);

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseEnter(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.FromArgb(20, 20, 90);
        }

        private void pnlHeader_MouseLeave(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.MidnightBlue;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void imgMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtItemName.Clear();
            txtItemCode.Clear();
            txtItemSize.Clear();
            txtBarcode.Clear();
            txtOthers.Clear();
            txtTOtalQty.Clear();
            txtPrchsPrc.Clear();
            txtMiniPrc.Clear();
            txtSellPrc.Clear();
            txtDiscount.Clear();
            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;


            medchine_imege.Image = null; // Clear image
        }

        private void medchine_imege_Click(object sender, EventArgs e)
        {
            try
            {
                var sa = new OpenFileDialog
                {
                    Filter = "JPEG *.jpg|*.jpg|png *.png|*.png"
                };
                sa.InitialDirectory = @"c:\ImagePath";
                if (sa.ShowDialog() == DialogResult.OK)
                {
                    medchine_imege.Load(sa.FileName);
                }

                sa.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddnewMedchin_servies _col = new AddnewMedchin_servies();

            _col.UpdateData(txtItemCode.Text, txtItemCode.Text, txtItemSize.Text, cmbBrand.Text, cmbCategory.Text, cmbSupplier.Text, txtBarcode.Text, txtOthers.Text, int.Parse(txtQty.Text), int.Parse(txtTOtalQty.Text),
                DateTime.Now, DateTime.Now, DateTime.Now, int.Parse(txtPrchsPrc.Text), int.Parse(txtMiniPrc.Text), int.Parse(txtSellPrc.Text), int.Parse(txtDiscount.Text));
            MessageBox.Show("Update Successfully");
            ClearAll();

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            AddnewMedchin_servies _col = new AddnewMedchin_servies();

            var ms = new MemoryStream();
            medchine_imege.Image.Save(ms, medchine_imege.Image.RawFormat);
            byte[] img = ms.GetBuffer();
            ms.Close();

            _col.AddData(txtItemName.Text, txtItemCode.Text, txtItemSize.Text, cmbBrand.Text, cmbCategory.Text, cmbSupplier.Text, txtBarcode.Text, txtOthers.Text, int.Parse(txtQty.Text), int.Parse(txtTOtalQty.Text), DateTime.Now, DateTime.Now, DateTime.Now, int.Parse(txtPrchsPrc.Text), int.Parse(txtMiniPrc.Text), int.Parse(txtSellPrc.Text), int.Parse(txtDiscount.Text), img);
            MessageBox.Show("Prodect Successfully Save");
            //ListData();
            ClearAll();
        }

        public void LoadData(string itemCode)
        {
            try
            {
                AddnewMedchin_servies _col = new AddnewMedchin_servies();
                var medicines = _col.ListAll();
                var medicine = medicines.FirstOrDefault(x => x.Itemcode == itemCode);

                if (medicine != null)
                {
                    txtItemName.Text = medicine.Itemname;
                    txtItemCode.Text = medicine.Itemcode;
                    txtItemSize.Text = medicine.Itemsize;
                    cmbBrand.Text = medicine.Itembrand;
                    cmbCategory.Text = medicine.Itemcategory;
                    cmbSupplier.Text = medicine.Itamsupplier;
                    txtBarcode.Text = medicine.Itembarcode;
                    txtOthers.Text = medicine.others;
                    txtQty.Text = medicine.Itemquantity.ToString();
                    txtTOtalQty.Text = medicine.Totalquantity.ToString();
                    txtPrchsPrc.Text = medicine.Purchaseprice.ToString();
                    txtMiniPrc.Text = medicine.Minimumprice.ToString();
                    txtSellPrc.Text = medicine.Sallingprice.ToString();
                    txtDiscount.Text = medicine.Dicount.ToString();

                    if (medicine.Imag != null)
                    {
                        using (var ms = new MemoryStream(medicine.Imag))
                        {
                            medchine_imege.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        medchine_imege.Image = null; // Clear image if there is no image data
                    }
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_lode_data_Click(object sender, EventArgs e)
        {
            var itemCode = txtItemCode.Text; // Retrieve the item code from the text box

            if (!string.IsNullOrEmpty(itemCode))
            {
                LoadData(itemCode); // Load the data for the specified item code
            }
            else
            {
                MessageBox.Show("Please enter an item code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
