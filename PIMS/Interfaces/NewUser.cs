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
    public partial class NewUserForm : Form
    {
        

        public NewUserForm()
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
            btnAddQty.Click += BtnAddQty_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnReset.Click += btnReset_Click;
            btnCancel.Click += btnCancel_Click;
            
        }

        private void BtnAddQty_Click(object sender, EventArgs e)
        {
            UsersUserControl_Services _col = new UsersUserControl_Services();

            var ms = new MemoryStream();
            pictureBox_Imege.Image.Save(ms, pictureBox_Imege.Image.RawFormat);
            byte[] img = ms.GetBuffer();
            ms.Close();

            _col.AddData(cmbRole.Text,txtFirstname.Text,txtLastName.Text,ComGender.Text,int.Parse(txtPhone.Text),txtMail.Text,txtNIC.Text,txtAddress.Text,dateOfBirth.MaxDate ,joinDate.MaxDate,txtUserName.Text,txtPassword.Text,img);
            MessageBox.Show("User Successfully Save");
            
            ClearAll();

        }

        //Custom drag bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int tree, int four);

        private void btnReset_Click(object sender, EventArgs e)
        {
            {
                var Data = new UsersUserControl_Services();

                var msg = MessageBox.Show("Are u sure want to reset ?", "reset Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                   // var id = kryptonDataGridView_UsersUserControl_Services.CurrentRow.Cells[0].Value.ToString().Trim();//

                  //  Data.ResetData();//
                 
                }
            }
            ClearAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pnlHeader_MouseEnter(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.FromArgb(20, 20, 90);
        }

        private void pnlHeader_MouseLeave(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.MidnightBlue;
        }

        private void imgMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                    pictureBox_Imege.Load(sa.FileName);
                }

                sa.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

         void ClearAll() {
            txtFirstname.Clear();
            txtLastName.Clear();
            txtMail.Clear();
            txtNIC.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtUserName.Clear();
            txtAddress.Clear();
            cmbRole.SelectedIndex = 0;
            ComGender.SelectedIndex = 0;
            PictureBox pictureBox_Imege;


         }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }

}

