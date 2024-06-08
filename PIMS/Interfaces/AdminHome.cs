using PIMS.Interfaces;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PIMS
{
    public partial class AdminHomeForm : Form
    {
        
        public AdminHomeForm()
        {
            bool slide;
            InitializeComponent();


            timeTimer.Start();

            
            
            //when login Deshboard on top
            dashboardUserControl.BringToFront();
            pnlSelect.Location = new System.Drawing.Point(pnlDashboardbtn.Location.X, pnlDashboardbtn.Location.Y);
            lblDesplayName.Text = "DASHBOARD";
            


            //To remove header
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.DoubleBuffered = true;

            

        }

        //Custom drag bar
        [DllImport("user32.DLL", EntryPoint= "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one,int two,int tree, int four);

        
        private void imgLogOut_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to Log out?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void imgSwitchAcc_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to switch Account?", "Switch user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboardUserControl.BringToFront();
            pnlSelect.Location = new System.Drawing.Point(pnlDashboardbtn.Location.X, pnlDashboardbtn.Location.Y);
            lblDesplayName.Text = "DASHBOARD";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            usersUserControl.BringToFront();
            pnlSelect.Location = new System.Drawing.Point(pnlUsersbtn.Location.X, pnlUsersbtn.Location.Y);
            lblDesplayName.Text = "USERS";
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            
            medicineUserControl.BringToFront();
            pnlSelect.Location = new System.Drawing.Point(pnlMedicinebtn.Location.X, pnlMedicinebtn.Location.Y);
            lblDesplayName.Text = "MEDICINES";

            Load += AdminHomeForm_Load;


        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            MedicineUserControl us = new MedicineUserControl();
            

            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            selling_us1.BringToFront();
            pnlSelect.Location = new System.Drawing.Point(pnlOrderbtn.Location.X, pnlOrderbtn.Location.Y);
            lblDesplayName.Text = "SELLING";
            
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportUserControl.BringToFront();
            pnlSelect.Location = new System.Drawing.Point(pnlReportbtn.Location.X, pnlReportbtn.Location.Y);
            lblDesplayName.Text = "REPORT";
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString();
        }

        private void pnlSlide_Resize(object sender, EventArgs e)
        {
            if (pnlSlide.Height < 665 && pnlSlide.Width == 213)
            {
                imgSwitchAcc.Location = new System.Drawing.Point(imgLogOut.Location.X + 46, imgLogOut.Location.Y);
                
            }
            else
            {
                imgSwitchAcc.Location = new System.Drawing.Point(imgLogOut.Location.X, imgLogOut.Location.Y - 40);
            }
        }

        private void imgMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            imgRestore.BringToFront();
        }

        private void imgRestore_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState=FormWindowState.Normal;
            imgMaximize.BringToFront();
        }

        private void imgMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

            
            
        }


        private void pnlHeader_MouseLeave(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.MidnightBlue;
        }

        private void pnlHeader_MouseEnter(object sender, EventArgs e)
        {
            pnlHeader.BackColor = pnlSlide.BackColor;
        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if the slidebar expand Minimize
            if (pnlSlide.Width == pnlDashboardbtn.Width)
            {
                btnMenu.Location = new Point(121, 3);

                pnlSlide.Width = imgSwitchAcc.Width + 13;

                
                if (pnlSlide.Width == imgSwitchAcc.Width + 13)
                {
                    pnlSlide.AutoScroll = false;
                }

            }
            //if the slidebar minimized Expand
            else if (pnlSlide.Width == imgSwitchAcc.Width + 13)
            {
                btnMenu.Location = new Point(115, 3);

                pnlSlide.Width = pnlDashboardbtn.Width;
                pnlSlide.AutoScroll = true;

            }
        }

        private void usersUserControl_Load(object sender, EventArgs e)
        {

        }




       /* public void FormInPanel(Panel usersUserControl, Form AdminHomeForm)
        {
            if (usersUserControl.Controls.Count > 0)
                usersUserControl.Controls.RemoveAt(0);

            usersUserControl.BackColor = Color.AliceBlue;
            AdminHomeForm.TopLevel = false;
            usersUserControl.Controls.Add(AdminHomeForm);

            AdminHomeForm.Location = new Point((usersUserControl.Width - AdminHomeForm.Width) / 2, (usersUserControl.Height - AdminHomeForm.Height) / 2);
            usersUserControl.Tag = AdminHomeForm;
            AdminHomeForm.Show();

        }*/












    }
}
