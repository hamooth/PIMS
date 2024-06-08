using PIMS.Servies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Interfaces
{
    public partial class MedicineUserControl : UserControl
    {
        public MedicineUserControl()
        {
            InitializeComponent();

           

            Load += MedicineUserControl_Load;


            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;


        }

        private void MedicineUserControl_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void btnNewMedi_Click(object sender, EventArgs e)
        {
            NewMedicine1 newMedicineForm = new NewMedicine1();
            newMedicineForm.Show();
        }

        private void btnAddQty_Click(object sender, EventArgs e)
        {

            bool Found = false;
            if (dataGridViewMedicines.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewMedicines.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == dataGridViewMedicines.Text &&
                        Convert.ToString(row.Cells[1].Value) == dataGridViewMedicines.Text)
                    {
                        row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        Found = true;
                    }
                }
                if (!Found)
                {
                    dataGridViewMedicines.Rows.Add(txtSearch.Text, cmbBrand.Text, 1);
                }
            }
            else
            {
                dataGridViewMedicines.Rows.Add(txtSearch.Text, cmbBrand.Text, 1);
            }




            /*AddQtyForm addQtyForm = new AddQtyForm();
            addQtyForm.Show();*/
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        void ListData()
        {
            AddnewMedchin_servies Data = new AddnewMedchin_servies();
            dataGridViewMedicines.DataSource = Data.ListAll();
        }
    }

}
