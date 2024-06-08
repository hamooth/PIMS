namespace PIMS
{
    partial class AdminHomeForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.imgAdmin = new System.Windows.Forms.PictureBox();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.pnlMenubtn = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReportbtn = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlOrderbtn = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlMedicinebtn = new System.Windows.Forms.Panel();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.pnlUsersbtn = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlDashboardbtn = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.imgSwitchAcc = new System.Windows.Forms.PictureBox();
            this.imgLogOut = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDesplayName = new System.Windows.Forms.Label();
            this.imgMinimize = new System.Windows.Forms.PictureBox();
            this.imgMaximize = new System.Windows.Forms.PictureBox();
            this.imgRestore = new System.Windows.Forms.PictureBox();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pcrNotification = new System.Windows.Forms.PictureBox();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.selling_us1 = new PIMS.Interfaces.Selling_us();
            this.ordersUserControl = new PIMS.Interfaces.OrdersUserControl();
            this.medicineUserControl = new PIMS.Interfaces.MedicineUserControl();
            this.usersUserControl = new PIMS.Interfaces.UsersUserControl();
            this.dashboardUserControl = new PIMS.Dashboard.DashboardUserControl();
            this.reportUserControl = new PIMS.Interfaces.ReportUserControl();
            this.pnlSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).BeginInit();
            this.pnlMenubtn.SuspendLayout();
            this.pnlReportbtn.SuspendLayout();
            this.pnlOrderbtn.SuspendLayout();
            this.pnlMedicinebtn.SuspendLayout();
            this.pnlUsersbtn.SuspendLayout();
            this.pnlDashboardbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSwitchAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogOut)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrNotification)).BeginInit();
            this.pnlUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSlide
            // 
            this.pnlSlide.AutoScroll = true;
            this.pnlSlide.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            this.pnlSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.pnlSlide.Controls.Add(this.imgAdmin);
            this.pnlSlide.Controls.Add(this.pnlSelect);
            this.pnlSlide.Controls.Add(this.pnlMenubtn);
            this.pnlSlide.Controls.Add(this.label1);
            this.pnlSlide.Controls.Add(this.pnlReportbtn);
            this.pnlSlide.Controls.Add(this.pnlOrderbtn);
            this.pnlSlide.Controls.Add(this.pnlMedicinebtn);
            this.pnlSlide.Controls.Add(this.pnlUsersbtn);
            this.pnlSlide.Controls.Add(this.pnlDashboardbtn);
            this.pnlSlide.Controls.Add(this.imgSwitchAcc);
            this.pnlSlide.Controls.Add(this.imgLogOut);
            this.pnlSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlide.Location = new System.Drawing.Point(0, 0);
            this.pnlSlide.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(284, 844);
            this.pnlSlide.TabIndex = 0;
            this.pnlSlide.Resize += new System.EventHandler(this.pnlSlide_Resize);
            // 
            // imgAdmin
            // 
            this.imgAdmin.Image = global::PIMS.Properties.Resources.UserW512;
            this.imgAdmin.Location = new System.Drawing.Point(60, 31);
            this.imgAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.imgAdmin.Name = "imgAdmin";
            this.imgAdmin.Size = new System.Drawing.Size(165, 156);
            this.imgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAdmin.TabIndex = 0;
            this.imgAdmin.TabStop = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlSelect.Location = new System.Drawing.Point(4, 181);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(13, 60);
            this.pnlSelect.TabIndex = 6;
            // 
            // pnlMenubtn
            // 
            this.pnlMenubtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenubtn.Controls.Add(this.btnMenu);
            this.pnlMenubtn.Location = new System.Drawing.Point(1, 245);
            this.pnlMenubtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenubtn.Name = "pnlMenubtn";
            this.pnlMenubtn.Size = new System.Drawing.Size(284, 60);
            this.pnlMenubtn.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMenu.Image = global::PIMS.Properties.Resources.menuW32px;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(153, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMenu.Size = new System.Drawing.Size(124, 53);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "  Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(115, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReportbtn
            // 
            this.pnlReportbtn.Controls.Add(this.btnReport);
            this.pnlReportbtn.Location = new System.Drawing.Point(0, 591);
            this.pnlReportbtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReportbtn.Name = "pnlReportbtn";
            this.pnlReportbtn.Size = new System.Drawing.Size(284, 60);
            this.pnlReportbtn.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReport.Image = global::PIMS.Properties.Resources.managementW32px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(8, 4);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(267, 53);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = " Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pnlOrderbtn
            // 
            this.pnlOrderbtn.Controls.Add(this.btnOrder);
            this.pnlOrderbtn.Location = new System.Drawing.Point(0, 523);
            this.pnlOrderbtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOrderbtn.Name = "pnlOrderbtn";
            this.pnlOrderbtn.Size = new System.Drawing.Size(284, 60);
            this.pnlOrderbtn.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrder.Image = global::PIMS.Properties.Resources.medicalOrderW32px;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(8, 4);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(267, 53);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = " Selling";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnlMedicinebtn
            // 
            this.pnlMedicinebtn.Controls.Add(this.btnMedicine);
            this.pnlMedicinebtn.Location = new System.Drawing.Point(0, 455);
            this.pnlMedicinebtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMedicinebtn.Name = "pnlMedicinebtn";
            this.pnlMedicinebtn.Size = new System.Drawing.Size(284, 60);
            this.pnlMedicinebtn.TabIndex = 3;
            // 
            // btnMedicine
            // 
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMedicine.Image = global::PIMS.Properties.Resources.medicineW32px;
            this.btnMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicine.Location = new System.Drawing.Point(8, 4);
            this.btnMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(267, 53);
            this.btnMedicine.TabIndex = 2;
            this.btnMedicine.Text = " Medicines";
            this.btnMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // pnlUsersbtn
            // 
            this.pnlUsersbtn.Controls.Add(this.btnUser);
            this.pnlUsersbtn.Location = new System.Drawing.Point(0, 388);
            this.pnlUsersbtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsersbtn.Name = "pnlUsersbtn";
            this.pnlUsersbtn.Size = new System.Drawing.Size(284, 60);
            this.pnlUsersbtn.TabIndex = 3;
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUser.Image = global::PIMS.Properties.Resources.userW32px;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(8, 4);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(267, 53);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = " Users";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlDashboardbtn
            // 
            this.pnlDashboardbtn.Controls.Add(this.btnDashboard);
            this.pnlDashboardbtn.Location = new System.Drawing.Point(0, 316);
            this.pnlDashboardbtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDashboardbtn.Name = "pnlDashboardbtn";
            this.pnlDashboardbtn.Size = new System.Drawing.Size(284, 60);
            this.pnlDashboardbtn.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDashboard.Image = global::PIMS.Properties.Resources.dashboardW32px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(8, 4);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(267, 53);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // imgSwitchAcc
            // 
            this.imgSwitchAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgSwitchAcc.Image = global::PIMS.Properties.Resources.swichAccW512px;
            this.imgSwitchAcc.Location = new System.Drawing.Point(15, 743);
            this.imgSwitchAcc.Margin = new System.Windows.Forms.Padding(4);
            this.imgSwitchAcc.Name = "imgSwitchAcc";
            this.imgSwitchAcc.Size = new System.Drawing.Size(43, 39);
            this.imgSwitchAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSwitchAcc.TabIndex = 8;
            this.imgSwitchAcc.TabStop = false;
            this.imgSwitchAcc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgSwitchAcc_MouseClick);
            // 
            // imgLogOut
            // 
            this.imgLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgLogOut.Image = global::PIMS.Properties.Resources.turn_offR512px;
            this.imgLogOut.Location = new System.Drawing.Point(15, 791);
            this.imgLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.imgLogOut.Name = "imgLogOut";
            this.imgLogOut.Size = new System.Drawing.Size(43, 39);
            this.imgLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogOut.TabIndex = 7;
            this.imgLogOut.TabStop = false;
            this.imgLogOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgLogOut_MouseClick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.pnlHeader);
            this.pnlTop.Controls.Add(this.lblDateTime);
            this.pnlTop.Controls.Add(this.pcrNotification);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(284, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1145, 71);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblDesplayName);
            this.pnlHeader.Controls.Add(this.imgMinimize);
            this.pnlHeader.Controls.Add(this.imgMaximize);
            this.pnlHeader.Controls.Add(this.imgRestore);
            this.pnlHeader.Controls.Add(this.imgClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1145, 30);
            this.pnlHeader.TabIndex = 7;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseEnter += new System.EventHandler(this.pnlHeader_MouseEnter);
            this.pnlHeader.MouseLeave += new System.EventHandler(this.pnlHeader_MouseLeave);
            // 
            // lblDesplayName
            // 
            this.lblDesplayName.AutoSize = true;
            this.lblDesplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDesplayName.Location = new System.Drawing.Point(20, 4);
            this.lblDesplayName.Name = "lblDesplayName";
            this.lblDesplayName.Size = new System.Drawing.Size(131, 20);
            this.lblDesplayName.TabIndex = 11;
            this.lblDesplayName.Text = "Desplay Name";
            // 
            // imgMinimize
            // 
            this.imgMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimize.BackColor = System.Drawing.Color.Transparent;
            this.imgMinimize.Image = global::PIMS.Properties.Resources.minimizeW32px;
            this.imgMinimize.Location = new System.Drawing.Point(1060, 4);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.Size = new System.Drawing.Size(27, 22);
            this.imgMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimize.TabIndex = 9;
            this.imgMinimize.TabStop = false;
            this.imgMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgMinimize_MouseClick);
            // 
            // imgMaximize
            // 
            this.imgMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMaximize.BackColor = System.Drawing.Color.Transparent;
            this.imgMaximize.Image = global::PIMS.Properties.Resources.maximizeW32px;
            this.imgMaximize.Location = new System.Drawing.Point(1088, 2);
            this.imgMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.imgMaximize.Name = "imgMaximize";
            this.imgMaximize.Size = new System.Drawing.Size(27, 25);
            this.imgMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMaximize.TabIndex = 8;
            this.imgMaximize.TabStop = false;
            this.imgMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgMaximize_MouseClick);
            // 
            // imgRestore
            // 
            this.imgRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgRestore.BackColor = System.Drawing.Color.Transparent;
            this.imgRestore.Image = global::PIMS.Properties.Resources.RestoreDownW32px;
            this.imgRestore.Location = new System.Drawing.Point(1088, 2);
            this.imgRestore.Margin = new System.Windows.Forms.Padding(4);
            this.imgRestore.Name = "imgRestore";
            this.imgRestore.Size = new System.Drawing.Size(27, 25);
            this.imgRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRestore.TabIndex = 10;
            this.imgRestore.TabStop = false;
            this.imgRestore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgRestore_MouseClick);
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.BackColor = System.Drawing.Color.Transparent;
            this.imgClose.Image = global::PIMS.Properties.Resources.close_button512px;
            this.imgClose.Location = new System.Drawing.Point(1116, 2);
            this.imgClose.Margin = new System.Windows.Forms.Padding(4);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(27, 25);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClose.TabIndex = 7;
            this.imgClose.TabStop = false;
            this.imgClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgLogOut_MouseClick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(23, 39);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(90, 18);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date & Time";
            // 
            // pcrNotification
            // 
            this.pcrNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcrNotification.Image = global::PIMS.Properties.Resources.bell;
            this.pcrNotification.Location = new System.Drawing.Point(1023, 36);
            this.pcrNotification.Margin = new System.Windows.Forms.Padding(4);
            this.pcrNotification.Name = "pcrNotification";
            this.pcrNotification.Size = new System.Drawing.Size(32, 32);
            this.pcrNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcrNotification.TabIndex = 0;
            this.pcrNotification.TabStop = false;
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Controls.Add(this.selling_us1);
            this.pnlUserControl.Controls.Add(this.ordersUserControl);
            this.pnlUserControl.Controls.Add(this.medicineUserControl);
            this.pnlUserControl.Controls.Add(this.usersUserControl);
            this.pnlUserControl.Controls.Add(this.dashboardUserControl);
            this.pnlUserControl.Controls.Add(this.reportUserControl);
            this.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserControl.Location = new System.Drawing.Point(284, 71);
            this.pnlUserControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(1145, 773);
            this.pnlUserControl.TabIndex = 1;
            // 
            // selling_us1
            // 
            this.selling_us1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selling_us1.Location = new System.Drawing.Point(0, 0);
            this.selling_us1.Name = "selling_us1";
            this.selling_us1.Size = new System.Drawing.Size(1145, 773);
            this.selling_us1.TabIndex = 5;
            // 
            // ordersUserControl
            // 
            this.ordersUserControl.BackColor = System.Drawing.Color.White;
            this.ordersUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersUserControl.Location = new System.Drawing.Point(0, 0);
            this.ordersUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.ordersUserControl.Name = "ordersUserControl";
            this.ordersUserControl.Size = new System.Drawing.Size(1145, 773);
            this.ordersUserControl.TabIndex = 3;
            // 
            // medicineUserControl
            // 
            this.medicineUserControl.AutoScroll = true;
            this.medicineUserControl.BackColor = System.Drawing.Color.White;
            this.medicineUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineUserControl.Location = new System.Drawing.Point(0, 0);
            this.medicineUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.medicineUserControl.Name = "medicineUserControl";
            this.medicineUserControl.Size = new System.Drawing.Size(1145, 773);
            this.medicineUserControl.TabIndex = 2;
            // 
            // usersUserControl
            // 
            this.usersUserControl.BackColor = System.Drawing.Color.White;
            this.usersUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersUserControl.Location = new System.Drawing.Point(0, 0);
            this.usersUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.usersUserControl.Name = "usersUserControl";
            this.usersUserControl.Size = new System.Drawing.Size(1145, 773);
            this.usersUserControl.TabIndex = 1;
            this.usersUserControl.Load += new System.EventHandler(this.usersUserControl_Load);
            // 
            // dashboardUserControl
            // 
            this.dashboardUserControl.BackColor = System.Drawing.Color.White;
            this.dashboardUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl.Location = new System.Drawing.Point(0, 0);
            this.dashboardUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.dashboardUserControl.Name = "dashboardUserControl";
            this.dashboardUserControl.Size = new System.Drawing.Size(1145, 773);
            this.dashboardUserControl.TabIndex = 0;
            // 
            // reportUserControl
            // 
            this.reportUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.reportUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportUserControl.Location = new System.Drawing.Point(0, 0);
            this.reportUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.reportUserControl.Name = "reportUserControl";
            this.reportUserControl.Size = new System.Drawing.Size(1145, 773);
            this.reportUserControl.TabIndex = 4;
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 844);
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1067, 737);
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home";
            this.pnlSlide.ResumeLayout(false);
            this.pnlSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).EndInit();
            this.pnlMenubtn.ResumeLayout(false);
            this.pnlReportbtn.ResumeLayout(false);
            this.pnlOrderbtn.ResumeLayout(false);
            this.pnlMedicinebtn.ResumeLayout(false);
            this.pnlUsersbtn.ResumeLayout(false);
            this.pnlDashboardbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSwitchAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogOut)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrNotification)).EndInit();
            this.pnlUserControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgAdmin;
        private System.Windows.Forms.Panel pnlOrderbtn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlMedicinebtn;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Panel pnlUsersbtn;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlDashboardbtn;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlReportbtn;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.PictureBox pcrNotification;
        private System.Windows.Forms.PictureBox imgSwitchAcc;
        private System.Windows.Forms.PictureBox imgLogOut;
        private System.Windows.Forms.Panel pnlUserControl;
        private Dashboard.DashboardUserControl dashboardUserControl;
        private Interfaces.UsersUserControl usersUserControl;
        private Interfaces.MedicineUserControl medicineUserControl;
        private Interfaces.OrdersUserControl ordersUserControl;
        private Interfaces.ReportUserControl reportUserControl;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Panel pnlMenubtn;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.PictureBox imgRestore;
        private System.Windows.Forms.PictureBox imgMinimize;
        private System.Windows.Forms.PictureBox imgMaximize;
        private System.Windows.Forms.Label lblDesplayName;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Panel pnlSlide;
        private Interfaces.Selling_us selling_us1;
    }
}