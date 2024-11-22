namespace Other
{
    partial class AddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.cmbMucDo = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcNgayThang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nupPhutBD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupGioBD = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nupPhutKT = new System.Windows.Forms.NumericUpDown();
            this.nupGioKT = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtgvJobChild = new System.Windows.Forms.DataGridView();
            this.clStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clJobChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.chbJob = new System.Windows.Forms.CheckBox();
            this.tcNgayThang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioBD)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioKT)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvJobChild)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Location = new System.Drawing.Point(55, 35);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTen.Size = new System.Drawing.Size(291, 29);
            this.txtTen.TabIndex = 4;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(16, 10);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(145, 26);
            this.dtpNgayKT.TabIndex = 7;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(16, 10);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(145, 26);
            this.dtpNgayBD.TabIndex = 8;
            // 
            // cmbMucDo
            // 
            this.cmbMucDo.FormattingEnabled = true;
            this.cmbMucDo.Items.AddRange(new object[] {
            "None",
            "Important"});
            this.cmbMucDo.Location = new System.Drawing.Point(96, 90);
            this.cmbMucDo.Name = "cmbMucDo";
            this.cmbMucDo.Size = new System.Drawing.Size(123, 28);
            this.cmbMucDo.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(368, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 52);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnSave.Location = new System.Drawing.Point(327, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 49);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcNgayThang
            // 
            this.tcNgayThang.Controls.Add(this.tabPage1);
            this.tcNgayThang.Controls.Add(this.tabPage2);
            this.tcNgayThang.Location = new System.Drawing.Point(21, 140);
            this.tcNgayThang.Name = "tcNgayThang";
            this.tcNgayThang.SelectedIndex = 0;
            this.tcNgayThang.Size = new System.Drawing.Size(449, 80);
            this.tcNgayThang.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nupPhutBD);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nupGioBD);
            this.tabPage1.Controls.Add(this.dtpNgayBD);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 47);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Ngày bắt đầu     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nupPhutBD
            // 
            this.nupPhutBD.Location = new System.Drawing.Point(302, 10);
            this.nupPhutBD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupPhutBD.Name = "nupPhutBD";
            this.nupPhutBD.Size = new System.Drawing.Size(65, 26);
            this.nupPhutBD.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(383, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "phút";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(255, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "giờ";
            // 
            // nupGioBD
            // 
            this.nupGioBD.Location = new System.Drawing.Point(184, 10);
            this.nupGioBD.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupGioBD.Name = "nupGioBD";
            this.nupGioBD.Size = new System.Drawing.Size(65, 26);
            this.nupGioBD.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nupPhutKT);
            this.tabPage2.Controls.Add(this.dtpNgayKT);
            this.tabPage2.Controls.Add(this.nupGioKT);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 47);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Ngày kết thúc     ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nupPhutKT
            // 
            this.nupPhutKT.Location = new System.Drawing.Point(302, 10);
            this.nupPhutKT.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupPhutKT.Name = "nupPhutKT";
            this.nupPhutKT.Size = new System.Drawing.Size(65, 26);
            this.nupPhutKT.TabIndex = 9;
            // 
            // nupGioKT
            // 
            this.nupGioKT.Location = new System.Drawing.Point(184, 10);
            this.nupGioKT.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupGioKT.Name = "nupGioKT";
            this.nupGioKT.Size = new System.Drawing.Size(65, 26);
            this.nupGioKT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(383, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "phút";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(255, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "giờ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công việc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mức độ:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(21, 236);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(453, 297);
            this.tabControl2.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtNotes);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(445, 264);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "     Mô tả     ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 3);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(439, 258);
            this.txtNotes.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtgvJobChild);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(445, 264);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "     Công việc con     ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtgvJobChild
            // 
            this.dtgvJobChild.AllowUserToResizeColumns = false;
            this.dtgvJobChild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvJobChild.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvJobChild.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvJobChild.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvJobChild.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvJobChild.ColumnHeadersHeight = 34;
            this.dtgvJobChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvJobChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStatus,
            this.clJobChild,
            this.clRemove});
            this.dtgvJobChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvJobChild.Location = new System.Drawing.Point(3, 3);
            this.dtgvJobChild.Name = "dtgvJobChild";
            this.dtgvJobChild.RowHeadersWidth = 30;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dtgvJobChild.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvJobChild.Size = new System.Drawing.Size(439, 258);
            this.dtgvJobChild.TabIndex = 0;
            this.dtgvJobChild.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListJobChild_CellContentClick);
            // 
            // clStatus
            // 
            this.clStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clStatus.FillWeight = 39.51447F;
            this.clStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clStatus.Frozen = true;
            this.clStatus.HeaderText = "";
            this.clStatus.MinimumWidth = 8;
            this.clStatus.Name = "clStatus";
            this.clStatus.Width = 39;
            // 
            // clJobChild
            // 
            this.clJobChild.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clJobChild.FillWeight = 300F;
            this.clJobChild.Frozen = true;
            this.clJobChild.HeaderText = "Tên công việc con";
            this.clJobChild.MinimumWidth = 8;
            this.clJobChild.Name = "clJobChild";
            this.clJobChild.Width = 300;
            // 
            // clRemove
            // 
            this.clRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clRemove.FillWeight = 68.18182F;
            this.clRemove.HeaderText = "Xóa";
            this.clRemove.MinimumWidth = 8;
            this.clRemove.Name = "clRemove";
            this.clRemove.Width = 68;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(21, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm cv con ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(267, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thể loại:";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(342, 90);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(100, 26);
            this.txtTheLoai.TabIndex = 15;
            // 
            // chbJob
            // 
            this.chbJob.AutoSize = true;
            this.chbJob.Location = new System.Drawing.Point(21, 36);
            this.chbJob.Name = "chbJob";
            this.chbJob.Size = new System.Drawing.Size(22, 21);
            this.chbJob.TabIndex = 16;
            this.chbJob.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(486, 600);
            this.Controls.Add(this.chbJob);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tcNgayThang);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbMucDo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "Add";
            this.tcNgayThang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioBD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioKT)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvJobChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.ComboBox cmbMucDo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcNgayThang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nupGioBD;
        private System.Windows.Forms.NumericUpDown nupPhutKT;
        private System.Windows.Forms.NumericUpDown nupGioKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nupPhutBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.CheckBox chbJob;
        private System.Windows.Forms.DataGridView dtgvJobChild;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clJobChild;
        private System.Windows.Forms.DataGridViewButtonColumn clRemove;
    }
}