namespace DỰ_ÁN_NHẮC_VIỆC
{
    partial class ListForm
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
            System.Windows.Forms.ListViewGroup listViewGroup23 = new System.Windows.Forms.ListViewGroup("Học tập", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup24 = new System.Windows.Forms.ListViewGroup("Mua sắm", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem(new string[] {
            "a",
            "Học tập",
            "10h",
            "20h",
            "Đang thực hiện",
            "Quan Trọng"}, -1);
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDanhSanhCV = new System.Windows.Forms.GroupBox();
            this.lvDanhSachCV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.gbCVcon = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1.SuspendLayout();
            this.gbDanhSanhCV.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.gbCVcon.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbCVcon);
            this.panel1.Controls.Add(this.gbDanhSanhCV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 860);
            this.panel1.TabIndex = 0;
            // 
            // gbDanhSanhCV
            // 
            this.gbDanhSanhCV.BackColor = System.Drawing.SystemColors.Control;
            this.gbDanhSanhCV.Controls.Add(this.lvDanhSachCV);
            this.gbDanhSanhCV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbDanhSanhCV.Location = new System.Drawing.Point(3, 88);
            this.gbDanhSanhCV.Name = "gbDanhSanhCV";
            this.gbDanhSanhCV.Size = new System.Drawing.Size(1298, 357);
            this.gbDanhSanhCV.TabIndex = 1;
            this.gbDanhSanhCV.TabStop = false;
            this.gbDanhSanhCV.Text = "Danh sách công việc";
            // 
            // lvDanhSachCV
            // 
            this.lvDanhSachCV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDanhSachCV.AllowColumnReorder = true;
            this.lvDanhSachCV.CheckBoxes = true;
            this.lvDanhSachCV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvDanhSachCV.FullRowSelect = true;
            listViewGroup23.Header = "Học tập";
            listViewGroup23.Name = "listViewGroup1";
            listViewGroup24.Header = "Mua sắm";
            listViewGroup24.Name = "listViewGroup2";
            this.lvDanhSachCV.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup23,
            listViewGroup24});
            this.lvDanhSachCV.HideSelection = false;
            listViewItem34.Group = listViewGroup23;
            listViewItem34.StateImageIndex = 0;
            listViewItem34.ToolTipText = "s";
            listViewItem35.Group = listViewGroup24;
            listViewItem35.StateImageIndex = 0;
            listViewItem36.Group = listViewGroup24;
            listViewItem36.StateImageIndex = 0;
            this.lvDanhSachCV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem34,
            listViewItem35,
            listViewItem36});
            this.lvDanhSachCV.Location = new System.Drawing.Point(3, 25);
            this.lvDanhSachCV.Name = "lvDanhSachCV";
            this.lvDanhSachCV.Size = new System.Drawing.Size(1280, 316);
            this.lvDanhSachCV.TabIndex = 0;
            this.lvDanhSachCV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachCV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên công việc";
            this.columnHeader1.Width = 315;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Loại ";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày bắt đầu";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày kết thúc";
            this.columnHeader4.Width = 159;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trạng thái";
            this.columnHeader5.Width = 148;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mức Độ";
            this.columnHeader6.Width = 154;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Địa điểm";
            this.columnHeader7.Width = 154;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.comboBox4);
            this.gbTimKiem.Controls.Add(this.comboBox2);
            this.gbTimKiem.Controls.Add(this.comboBox1);
            this.gbTimKiem.Controls.Add(this.dateTimePicker2);
            this.gbTimKiem.Controls.Add(this.dateTimePicker1);
            this.gbTimKiem.Controls.Add(this.textBox1);
            this.gbTimKiem.Controls.Add(this.txtTenCV);
            this.gbTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbTimKiem.Location = new System.Drawing.Point(0, 0);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(1298, 82);
            this.gbTimKiem.TabIndex = 0;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DONE",
            "DOING",
            "COMING",
            "MISSED"});
            this.comboBox1.Location = new System.Drawing.Point(782, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(482, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(117, 26);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // txtTenCV
            // 
            this.txtTenCV.ForeColor = System.Drawing.Color.Gray;
            this.txtTenCV.Location = new System.Drawing.Point(6, 34);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(192, 26);
            this.txtTenCV.TabIndex = 21;
            this.txtTenCV.Text = "Tên Công Việc";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DONE",
            "DOING",
            "COMING",
            "MISSED"});
            this.comboBox2.Location = new System.Drawing.Point(933, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 23;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "DONE",
            "DOING",
            "COMING",
            "MISSED"});
            this.comboBox4.Location = new System.Drawing.Point(318, 33);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 23;
            // 
            // gbCVcon
            // 
            this.gbCVcon.Controls.Add(this.panel2);
            this.gbCVcon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCVcon.Location = new System.Drawing.Point(9, 451);
            this.gbCVcon.Name = "gbCVcon";
            this.gbCVcon.Size = new System.Drawing.Size(1277, 409);
            this.gbCVcon.TabIndex = 2;
            this.gbCVcon.TabStop = false;
            this.gbCVcon.Text = "Thông tin công viêc";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(6, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 366);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(1092, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Địa điểm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1265, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(113, 33);
            this.toolStripLabel1.Text = "Công việc : a";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 25);
            this.toolStripProgressBar1.Value = 60;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 860);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.panel1);
            this.Name = "ListForm";
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.gbDanhSanhCV.ResumeLayout(false);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbCVcon.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDanhSanhCV;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.ListView lvDanhSachCV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox gbCVcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

