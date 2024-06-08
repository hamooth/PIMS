namespace PIMS
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.pcrClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlUsertxt = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlPasswordtxt = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgHidden = new System.Windows.Forms.PictureBox();
            this.pcrShow = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrClose)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrShow)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.leftPanel.Controls.Add(this.profileImage);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(331, 606);
            this.leftPanel.TabIndex = 0;
            // 
            // profileImage
            // 
            this.profileImage.Image = global::PIMS.Properties.Resources.pharmacy;
            this.profileImage.Location = new System.Drawing.Point(91, 80);
            this.profileImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(149, 150);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 256);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHARMACY INVENTORY MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CenterPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.CenterPanel.Location = new System.Drawing.Point(331, 0);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(7, 606);
            this.CenterPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rightPanel.Controls.Add(this.pcrClose);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.pnlLogin);
            this.rightPanel.Controls.Add(this.pnlUser);
            this.rightPanel.Controls.Add(this.pnlPassword);
            this.rightPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanel.Location = new System.Drawing.Point(333, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(429, 606);
            this.rightPanel.TabIndex = 1;
            // 
            // pcrClose
            // 
            this.pcrClose.Image = global::PIMS.Properties.Resources.close_button32px;
            this.pcrClose.Location = new System.Drawing.Point(381, 12);
            this.pcrClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcrClose.Name = "pcrClose";
            this.pcrClose.Size = new System.Drawing.Size(35, 32);
            this.pcrClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcrClose.TabIndex = 11;
            this.pcrClose.TabStop = false;
            this.pcrClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcrClose_MouseClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(55, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login your Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(3, 377);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(427, 57);
            this.pnlLogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::PIMS.Properties.Resources.enterW24px;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(121, 7);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.pnlUsertxt);
            this.pnlUser.Controls.Add(this.txtUserName);
            this.pnlUser.Controls.Add(this.pictureBox1);
            this.pnlUser.Location = new System.Drawing.Point(3, 249);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(427, 57);
            this.pnlUser.TabIndex = 3;
            // 
            // pnlUsertxt
            // 
            this.pnlUsertxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlUsertxt.Location = new System.Drawing.Point(56, 39);
            this.pnlUsertxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUsertxt.Name = "pnlUsertxt";
            this.pnlUsertxt.Size = new System.Drawing.Size(315, 4);
            this.pnlUsertxt.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(56, 17);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(315, 19);
            this.txtUserName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIMS.Properties.Resources.User512;
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.pnlPasswordtxt);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Controls.Add(this.pictureBox2);
            this.pnlPassword.Controls.Add(this.imgHidden);
            this.pnlPassword.Controls.Add(this.pcrShow);
            this.pnlPassword.Location = new System.Drawing.Point(3, 313);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(427, 57);
            this.pnlPassword.TabIndex = 4;
            // 
            // pnlPasswordtxt
            // 
            this.pnlPasswordtxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlPasswordtxt.Location = new System.Drawing.Point(56, 41);
            this.pnlPasswordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPasswordtxt.Name = "pnlPasswordtxt";
            this.pnlPasswordtxt.Size = new System.Drawing.Size(315, 4);
            this.pnlPasswordtxt.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(56, 18);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 19);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PIMS.Properties.Resources.padlockB512px;
            this.pictureBox2.Location = new System.Drawing.Point(17, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // imgHidden
            // 
            this.imgHidden.Image = global::PIMS.Properties.Resources.hide512px;
            this.imgHidden.Location = new System.Drawing.Point(379, 12);
            this.imgHidden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgHidden.Name = "imgHidden";
            this.imgHidden.Size = new System.Drawing.Size(32, 32);
            this.imgHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHidden.TabIndex = 8;
            this.imgHidden.TabStop = false;
            this.imgHidden.MouseHover += new System.EventHandler(this.imgHidden_MouseHover);
            // 
            // pcrShow
            // 
            this.pcrShow.Image = global::PIMS.Properties.Resources.show512px;
            this.pcrShow.Location = new System.Drawing.Point(379, 12);
            this.pcrShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcrShow.Name = "pcrShow";
            this.pcrShow.Size = new System.Drawing.Size(32, 32);
            this.pcrShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcrShow.TabIndex = 9;
            this.pcrShow.TabStop = false;
            this.pcrShow.MouseLeave += new System.EventHandler(this.pcrShow_MouseLeave);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 606);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcrClose)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgHidden;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcrClose;
        private System.Windows.Forms.PictureBox pcrShow;
        private System.Windows.Forms.Panel pnlUsertxt;
        private System.Windows.Forms.Panel pnlPasswordtxt;
    }
}

