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
    public partial class UsersUserControl : UserControl
    {
        public UsersUserControl()
        {
            InitializeComponent();
            ListData();

            dataGridViewUserCont.CellClick += DataGridViewUserCont_CellClick;
        }

        private void DataGridViewUserCont_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var id = dataGridViewUserCont.CurrentRow.Cells[0].Value.ToString().Trim();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
        }


        void ListData()
        {
            UsersUserControl_Services Data = new UsersUserControl_Services();
            dataGridViewUserCont.DataSource = Data.ListAll();
        }

        private void dataGridViewUserCont_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsersUserControl_Repo_fo frm = new UsersUserControl_Repo_fo();
            frm.Show();
        }
    }
}
