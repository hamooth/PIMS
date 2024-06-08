namespace PIMS.Dashboard
{
    partial class DashboardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTop5Item = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlSellQty = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlItemBlnc = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSellingBtn = new System.Windows.Forms.Panel();
            this.btnSelling = new System.Windows.Forms.Button();
            this.pnlTtlQty = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlExpItem = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlDashDetails = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Item)).BeginInit();
            this.pnlDate.SuspendLayout();
            this.pnlSellQty.SuspendLayout();
            this.pnlItemBlnc.SuspendLayout();
            this.pnlSellingBtn.SuspendLayout();
            this.pnlTtlQty.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlExpItem.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.pnlDashDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTop5Item
            // 
            this.chartTop5Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            chartArea1.Name = "ChartArea1";
            this.chartTop5Item.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartTop5Item.Legends.Add(legend1);
            this.chartTop5Item.Location = new System.Drawing.Point(525, 158);
            this.chartTop5Item.Name = "chartTop5Item";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.LabelAngle = 12;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTop5Item.Series.Add(series1);
            this.chartTop5Item.Size = new System.Drawing.Size(321, 377);
            this.chartTop5Item.TabIndex = 1;
            this.chartTop5Item.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Top 5 Items";
            this.chartTop5Item.Titles.Add(title1);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.dateTimePicker2);
            this.pnlDate.Controls.Add(this.label2);
            this.pnlDate.Controls.Add(this.label1);
            this.pnlDate.Controls.Add(this.dateTimePicker1);
            this.pnlDate.Location = new System.Drawing.Point(1, 6);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(854, 43);
            this.pnlDate.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(231, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 23);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pnlSellQty
            // 
            this.pnlSellQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            this.pnlSellQty.Controls.Add(this.label9);
            this.pnlSellQty.Controls.Add(this.label10);
            this.pnlSellQty.ForeColor = System.Drawing.Color.White;
            this.pnlSellQty.Location = new System.Drawing.Point(650, 9);
            this.pnlSellQty.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSellQty.Name = "pnlSellQty";
            this.pnlSellQty.Size = new System.Drawing.Size(196, 132);
            this.pnlSellQty.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 31);
            this.label9.TabIndex = 5;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Today Sell Qty";
            // 
            // pnlItemBlnc
            // 
            this.pnlItemBlnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            this.pnlItemBlnc.Controls.Add(this.label7);
            this.pnlItemBlnc.Controls.Add(this.label8);
            this.pnlItemBlnc.ForeColor = System.Drawing.Color.White;
            this.pnlItemBlnc.Location = new System.Drawing.Point(435, 9);
            this.pnlItemBlnc.Margin = new System.Windows.Forms.Padding(2);
            this.pnlItemBlnc.Name = "pnlItemBlnc";
            this.pnlItemBlnc.Size = new System.Drawing.Size(196, 132);
            this.pnlItemBlnc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Balance Item";
            // 
            // pnlSellingBtn
            // 
            this.pnlSellingBtn.BackColor = System.Drawing.Color.Transparent;
            this.pnlSellingBtn.Controls.Add(this.btnSelling);
            this.pnlSellingBtn.Location = new System.Drawing.Point(5, 9);
            this.pnlSellingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSellingBtn.Name = "pnlSellingBtn";
            this.pnlSellingBtn.Size = new System.Drawing.Size(196, 132);
            this.pnlSellingBtn.TabIndex = 7;
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.btnSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelling.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(198)))));
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.White;
            this.btnSelling.Image = global::PIMS.Properties.Resources.loanW64px;
            this.btnSelling.Location = new System.Drawing.Point(0, 0);
            this.btnSelling.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(196, 132);
            this.btnSelling.TabIndex = 0;
            this.btnSelling.Text = "Selling";
            this.btnSelling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // pnlTtlQty
            // 
            this.pnlTtlQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            this.pnlTtlQty.Controls.Add(this.label4);
            this.pnlTtlQty.Controls.Add(this.label3);
            this.pnlTtlQty.ForeColor = System.Drawing.Color.White;
            this.pnlTtlQty.Location = new System.Drawing.Point(220, 9);
            this.pnlTtlQty.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTtlQty.Name = "pnlTtlQty";
            this.pnlTtlQty.Size = new System.Drawing.Size(196, 132);
            this.pnlTtlQty.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Qty";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(5, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 132);
            this.panel2.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Recent User";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(5, 302);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 233);
            this.panel3.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Understock Items";
            // 
            // pnlExpItem
            // 
            this.pnlExpItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            this.pnlExpItem.Controls.Add(this.label5);
            this.pnlExpItem.ForeColor = System.Drawing.Color.White;
            this.pnlExpItem.Location = new System.Drawing.Point(266, 158);
            this.pnlExpItem.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExpItem.Name = "pnlExpItem";
            this.pnlExpItem.Size = new System.Drawing.Size(238, 132);
            this.pnlExpItem.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Expaired item";
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.pnlDashDetails);
            this.pnlBack.Controls.Add(this.pnlDate);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(859, 628);
            this.pnlBack.TabIndex = 9;
            // 
            // pnlDashDetails
            // 
            this.pnlDashDetails.Controls.Add(this.pnlSellingBtn);
            this.pnlDashDetails.Controls.Add(this.pnlTtlQty);
            this.pnlDashDetails.Controls.Add(this.panel3);
            this.pnlDashDetails.Controls.Add(this.pnlSellQty);
            this.pnlDashDetails.Controls.Add(this.chartTop5Item);
            this.pnlDashDetails.Controls.Add(this.pnlExpItem);
            this.pnlDashDetails.Controls.Add(this.pnlItemBlnc);
            this.pnlDashDetails.Controls.Add(this.panel2);
            this.pnlDashDetails.Location = new System.Drawing.Point(4, 79);
            this.pnlDashDetails.Name = "pnlDashDetails";
            this.pnlDashDetails.Size = new System.Drawing.Size(850, 546);
            this.pnlDashDetails.TabIndex = 10;
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBack);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(859, 628);
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Item)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlSellQty.ResumeLayout(false);
            this.pnlSellQty.PerformLayout();
            this.pnlItemBlnc.ResumeLayout(false);
            this.pnlItemBlnc.PerformLayout();
            this.pnlSellingBtn.ResumeLayout(false);
            this.pnlTtlQty.ResumeLayout(false);
            this.pnlTtlQty.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlExpItem.ResumeLayout(false);
            this.pnlExpItem.PerformLayout();
            this.pnlBack.ResumeLayout(false);
            this.pnlDashDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Item;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlSellQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlItemBlnc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlSellingBtn;
        private System.Windows.Forms.Panel pnlTtlQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Panel pnlExpItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlDashDetails;
    }
}
