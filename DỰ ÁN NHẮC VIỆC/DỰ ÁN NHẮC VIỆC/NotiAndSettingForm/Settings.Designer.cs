﻿namespace FormPhu
{
    partial class Settings
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
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.btnNhapXuat = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHienThiTB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnGioiThieu);
            this.panel1.Controls.Add(this.btnNhapXuat);
            this.panel1.Controls.Add(this.btnThongBao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioiThieu.Location = new System.Drawing.Point(0, 354);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(200, 38);
            this.btnGioiThieu.TabIndex = 2;
            this.btnGioiThieu.Text = "Giới thiệu";
            this.btnGioiThieu.UseVisualStyleBackColor = false;
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXuat.Location = new System.Drawing.Point(0, 113);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(200, 38);
            this.btnNhapXuat.TabIndex = 1;
            this.btnNhapXuat.Text = "Dữ liệu";
            this.btnNhapXuat.UseVisualStyleBackColor = false;
            this.btnNhapXuat.Click += new System.EventHandler(this.btnNhapXuat_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.Location = new System.Drawing.Point(0, 37);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(200, 38);
            this.btnThongBao.TabIndex = 0;
            this.btnThongBao.Text = "Thông báo";
            this.btnThongBao.UseVisualStyleBackColor = false;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hiển thị thông báo";
            // 
            // cbbHienThiTB
            // 
            this.cbbHienThiTB.FormattingEnabled = true;
            this.cbbHienThiTB.Location = new System.Drawing.Point(176, 26);
            this.cbbHienThiTB.Name = "cbbHienThiTB";
            this.cbbHienThiTB.Size = new System.Drawing.Size(121, 24);
            this.cbbHienThiTB.TabIndex = 2;
            this.cbbHienThiTB.SelectedIndexChanged += new System.EventHandler(this.cbbHienThiTB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbHienThiTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 450);
            this.panel2.TabIndex = 3;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhapXuat;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbHienThiTB;
        private System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.Panel panel2;
    }
}

