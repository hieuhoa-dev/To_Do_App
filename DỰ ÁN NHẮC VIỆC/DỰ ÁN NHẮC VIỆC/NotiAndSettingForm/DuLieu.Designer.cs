namespace FormPhu
{
    partial class frmDuLieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.cbxDaHT = new System.Windows.Forms.CheckBox();
            this.cbxSapToi = new System.Windows.Forms.CheckBox();
            this.cbxQuaHan = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dữ liệu";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(17, 56);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(110, 23);
            this.btnChonFile.TabIndex = 1;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xuất dữ liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lưu vào:";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.Location = new System.Drawing.Point(129, 349);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(494, 26);
            this.txtDuongDan.TabIndex = 4;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.Location = new System.Drawing.Point(662, 349);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(97, 26);
            this.btnThayDoi.TabIndex = 5;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            // 
            // cbxDaHT
            // 
            this.cbxDaHT.AutoSize = true;
            this.cbxDaHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDaHT.Location = new System.Drawing.Point(17, 208);
            this.cbxDaHT.Name = "cbxDaHT";
            this.cbxDaHT.Size = new System.Drawing.Size(139, 24);
            this.cbxDaHT.TabIndex = 6;
            this.cbxDaHT.Text = "Đã hoàn thành";
            this.cbxDaHT.UseVisualStyleBackColor = true;
            // 
            // cbxSapToi
            // 
            this.cbxSapToi.AutoSize = true;
            this.cbxSapToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSapToi.Location = new System.Drawing.Point(17, 247);
            this.cbxSapToi.Name = "cbxSapToi";
            this.cbxSapToi.Size = new System.Drawing.Size(83, 24);
            this.cbxSapToi.TabIndex = 7;
            this.cbxSapToi.Text = "Sắp tới";
            this.cbxSapToi.UseVisualStyleBackColor = true;
            // 
            // cbxQuaHan
            // 
            this.cbxQuaHan.AutoSize = true;
            this.cbxQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuaHan.Location = new System.Drawing.Point(17, 287);
            this.cbxQuaHan.Name = "cbxQuaHan";
            this.cbxQuaHan.Size = new System.Drawing.Size(94, 24);
            this.cbxQuaHan.TabIndex = 8;
            this.cbxQuaHan.Text = "Quá hạn";
            this.cbxQuaHan.UseVisualStyleBackColor = true;
            // 
            // frmDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxQuaHan);
            this.Controls.Add(this.cbxSapToi);
            this.Controls.Add(this.cbxDaHT);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDuLieu";
            this.Text = "DuLieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.CheckBox cbxDaHT;
        private System.Windows.Forms.CheckBox cbxSapToi;
        private System.Windows.Forms.CheckBox cbxQuaHan;
    }
}