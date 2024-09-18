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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDanhSanhCV = new System.Windows.Forms.GroupBox();
            this.lvDanhSachCV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.bttnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbDanhSanhCV.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDanhSanhCV);
            this.panel1.Controls.Add(this.gbTimKiem);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 842);
            this.panel1.TabIndex = 0;
            // 
            // gbDanhSanhCV
            // 
            this.gbDanhSanhCV.BackColor = System.Drawing.SystemColors.Control;
            this.gbDanhSanhCV.Controls.Add(this.lvDanhSachCV);
            this.gbDanhSanhCV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbDanhSanhCV.Location = new System.Drawing.Point(12, 184);
            this.gbDanhSanhCV.Name = "gbDanhSanhCV";
            this.gbDanhSanhCV.Size = new System.Drawing.Size(1262, 636);
            this.gbDanhSanhCV.TabIndex = 1;
            this.gbDanhSanhCV.TabStop = false;
            this.gbDanhSanhCV.Text = "Danh sách công việc";
            // 
            // lvDanhSachCV
            // 
            this.lvDanhSachCV.CheckBoxes = true;
            this.lvDanhSachCV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDanhSachCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachCV.GridLines = true;
            this.lvDanhSachCV.HideSelection = false;
            this.lvDanhSachCV.Location = new System.Drawing.Point(3, 22);
            this.lvDanhSachCV.Name = "lvDanhSachCV";
            this.lvDanhSachCV.Size = new System.Drawing.Size(1256, 611);
            this.lvDanhSachCV.TabIndex = 0;
            this.lvDanhSachCV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachCV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên công việc";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mô tả";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày bắt đầu";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày kết thúc";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trạng thái";
            this.columnHeader5.Width = 100;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.bttnThoat);
            this.gbTimKiem.Controls.Add(this.btnXoa);
            this.gbTimKiem.Controls.Add(this.bntThem);
            this.gbTimKiem.Controls.Add(this.btnTim);
            this.gbTimKiem.Controls.Add(this.comboBox1);
            this.gbTimKiem.Controls.Add(this.dateTimePicker1);
            this.gbTimKiem.Controls.Add(this.textBox1);
            this.gbTimKiem.Controls.Add(this.label2);
            this.gbTimKiem.Controls.Add(this.label3);
            this.gbTimKiem.Controls.Add(this.label1);
            this.gbTimKiem.Location = new System.Drawing.Point(12, 19);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(1259, 143);
            this.gbTimKiem.TabIndex = 0;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // bttnThoat
            // 
            this.bttnThoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttnThoat.ForeColor = System.Drawing.Color.Black;
            this.bttnThoat.Location = new System.Drawing.Point(1016, 76);
            this.bttnThoat.Name = "bttnThoat";
            this.bttnThoat.Size = new System.Drawing.Size(125, 36);
            this.bttnThoat.TabIndex = 27;
            this.bttnThoat.Text = "Thoát";
            this.bttnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(1016, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 36);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntThem.ForeColor = System.Drawing.Color.Black;
            this.bntThem.Location = new System.Drawing.Point(849, 76);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(125, 36);
            this.bntThem.TabIndex = 25;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(849, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(125, 36);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DONE",
            "DOING",
            "COMING",
            "MISSED"});
            this.comboBox1.Location = new System.Drawing.Point(604, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 26);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(455, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Theo trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Theo ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Theo tên cv";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1425, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 860);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "ListForm";
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.gbDanhSanhCV.ResumeLayout(false);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDanhSanhCV;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListView lvDanhSachCV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
    }
}

