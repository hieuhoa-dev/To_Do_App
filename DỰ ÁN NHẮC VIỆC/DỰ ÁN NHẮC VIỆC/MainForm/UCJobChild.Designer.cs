﻿namespace DỰ_ÁN_NHẮC_VIỆC
{
    partial class UCJobChild
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconFlat = new FontAwesome.Sharp.IconButton();
            this.progressBarJob = new System.Windows.Forms.ProgressBar();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.dgvListJobChild = new System.Windows.Forms.DataGridView();
            this.dtgvStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcNgayThang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nupPhutBD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupGioBD = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nupPhutKT = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.nupGioKT = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTipShowProgress = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJobChild)).BeginInit();
            this.tcNgayThang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioBD)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioKT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(24, 280);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(486, 90);
            this.txtNotes.TabIndex = 1;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả CV";
            // 
            // iconFlat
            // 
            this.iconFlat.BackColor = System.Drawing.Color.White;
            this.iconFlat.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconFlat.FlatAppearance.BorderSize = 0;
            this.iconFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFlat.ForeColor = System.Drawing.Color.Gray;
            this.iconFlat.IconChar = FontAwesome.Sharp.IconChar.Flag;
            this.iconFlat.IconColor = System.Drawing.Color.Black;
            this.iconFlat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFlat.IconSize = 25;
            this.iconFlat.Location = new System.Drawing.Point(443, 0);
            this.iconFlat.Name = "iconFlat";
            this.iconFlat.Size = new System.Drawing.Size(43, 53);
            this.iconFlat.TabIndex = 2;
            this.iconFlat.UseVisualStyleBackColor = false;
            this.iconFlat.Click += new System.EventHandler(this.iconFlat_Click);
            // 
            // progressBarJob
            // 
            this.progressBarJob.BackColor = System.Drawing.Color.Black;
            this.progressBarJob.Location = new System.Drawing.Point(24, 102);
            this.progressBarJob.Name = "progressBarJob";
            this.progressBarJob.Size = new System.Drawing.Size(486, 13);
            this.progressBarJob.TabIndex = 4;
            this.progressBarJob.Value = 60;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbTrangThai.Location = new System.Drawing.Point(0, 0);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(38, 53);
            this.cbTrangThai.TabIndex = 5;
            this.cbTrangThai.UseVisualStyleBackColor = true;
            this.cbTrangThai.CheckedChanged += new System.EventHandler(this.cbTrangThai_CheckedChanged);
            // 
            // dgvListJobChild
            // 
            this.dgvListJobChild.AllowUserToResizeColumns = false;
            this.dgvListJobChild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListJobChild.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListJobChild.BackgroundColor = System.Drawing.Color.White;
            this.dgvListJobChild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListJobChild.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListJobChild.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListJobChild.ColumnHeadersHeight = 34;
            this.dgvListJobChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListJobChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvStatus,
            this.dtgvName,
            this.DeleteColumn});
            this.dgvListJobChild.Location = new System.Drawing.Point(24, 401);
            this.dgvListJobChild.Name = "dgvListJobChild";
            this.dgvListJobChild.RowHeadersWidth = 30;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvListJobChild.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListJobChild.Size = new System.Drawing.Size(486, 459);
            this.dgvListJobChild.TabIndex = 8;
            this.dgvListJobChild.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListJobChild_CellContentClick);
            this.dgvListJobChild.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListJobChild_RowValidated);
            // 
            // dtgvStatus
            // 
            this.dtgvStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dtgvStatus.FillWeight = 39.51447F;
            this.dtgvStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dtgvStatus.Frozen = true;
            this.dtgvStatus.HeaderText = "";
            this.dtgvStatus.MinimumWidth = 8;
            this.dtgvStatus.Name = "dtgvStatus";
            this.dtgvStatus.Width = 39;
            // 
            // dtgvName
            // 
            this.dtgvName.FillWeight = 300F;
            this.dtgvName.HeaderText = "Tên công việc con";
            this.dtgvName.MinimumWidth = 8;
            this.dtgvName.Name = "dtgvName";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.FillWeight = 50F;
            this.DeleteColumn.HeaderText = "Xóa";
            this.DeleteColumn.MinimumWidth = 8;
            this.DeleteColumn.Name = "DeleteColumn";
            // 
            // tcNgayThang
            // 
            this.tcNgayThang.Controls.Add(this.tabPage1);
            this.tcNgayThang.Controls.Add(this.tabPage2);
            this.tcNgayThang.Location = new System.Drawing.Point(34, 137);
            this.tcNgayThang.Name = "tcNgayThang";
            this.tcNgayThang.SelectedIndex = 0;
            this.tcNgayThang.Size = new System.Drawing.Size(449, 80);
            this.tcNgayThang.TabIndex = 14;
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
            this.nupPhutBD.ValueChanged += new System.EventHandler(this.nupPhutBD_ValueChanged);
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
            this.nupGioBD.ValueChanged += new System.EventHandler(this.nupGioBD_ValueChanged);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(16, 10);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(145, 26);
            this.dtpNgayBD.TabIndex = 8;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nupPhutKT);
            this.tabPage2.Controls.Add(this.dtpNgayKT);
            this.tabPage2.Controls.Add(this.nupGioKT);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
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
            this.nupPhutKT.ValueChanged += new System.EventHandler(this.nupPhutKT_ValueChanged);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(16, 10);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(145, 26);
            this.dtpNgayKT.TabIndex = 7;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
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
            this.nupGioKT.ValueChanged += new System.EventHandler(this.nupGioKT_ValueChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "giờ";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(38, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(405, 68);
            this.txtName.TabIndex = 15;
            this.txtName.Text = "Xin chào";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.iconFlat);
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 53);
            this.panel1.TabIndex = 16;
            // 
            // toolTipShowProgress
            // 
            this.toolTipShowProgress.IsBalloon = true;
            // 
            // UCJobChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcNgayThang);
            this.Controls.Add(this.dgvListJobChild);
            this.Controls.Add(this.progressBarJob);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Name = "UCJobChild";
            this.Size = new System.Drawing.Size(526, 892);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJobChild)).EndInit();
            this.tcNgayThang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioBD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhutKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGioKT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconFlat;
        private System.Windows.Forms.ProgressBar progressBarJob;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.DataGridView dgvListJobChild;
        private System.Windows.Forms.TabControl tcNgayThang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nupPhutBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupGioBD;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nupPhutKT;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.NumericUpDown nupGioKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvName;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.ToolTip toolTipShowProgress;
    }
}
