using PIMS.DataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PIMS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void imgHidden_MouseHover(object sender, EventArgs e)
        {
            //The password visible
            txtPassword.UseSystemPasswordChar = false;
            imgHidden.Visible = false;
        }

        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*AdminHomeForm admin = new AdminHomeForm();
            admin.Show();
            this.Hide();*/

            /*if (txtUserName.Text=="Admin" && txtPassword.Text == "123")
            {
                
            }
            else
            {
                MessageBox.Show("Please enter correct User name & Password");
            }*/




            /*string Uname = txtUserName.Text.Trim();
            string Pwd = txtPassword.Text.Trim();

            var _LS = new Servies.Loginservices();

           var ch = _LS.ListAll().Select(x => new { x.Username, x.Password}).ToList();

            foreach (var item in ch)
            {
                if (Uname.Trim()==item.Username.Trim() && Pwd.Trim()==item.Password.Trim())
                {
                    MessageBox.Show("Login Success", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    AdminHomeForm admin = new AdminHomeForm();
                    admin.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login Failed", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
            }*/

            string Uname = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(Uname) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Username and Password are required.");
                return;
            }

            try
            {
                using (var context = new PIMS_DBEntities())
                {
                    var user = context.Table_add_new_user.SingleOrDefault(u => u.Username == Uname);

                    if (user != null)
                    {
                        // In a real application, use a proper password hashing mechanism
                        if (user.Password.Trim() == Password)
                        {
                            AdminHomeForm admin = new AdminHomeForm();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password or Username");
                            txtUserName.Clear();
                            txtPassword.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong password or Username");
                        txtUserName.Clear();
                        txtPassword.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }




        }

        private void pcrClose_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pcrShow_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            imgHidden.Visible = true;
        }
    }
}
