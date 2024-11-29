namespace DỰ_ÁN_NHẮC_VIỆC
{
    partial class ThongBaoCon
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
            this.lbLoaiTB = new System.Windows.Forms.Label();
            this.lbTenCV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconXmark = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbLoaiTB
            // 
            this.lbLoaiTB.AutoSize = true;
            this.lbLoaiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTB.ForeColor = System.Drawing.Color.Black;
            this.lbLoaiTB.Location = new System.Drawing.Point(26, 0);
            this.lbLoaiTB.Name = "lbLoaiTB";
            this.lbLoaiTB.Size = new System.Drawing.Size(61, 25);
            this.lbLoaiTB.TabIndex = 2;
            this.lbLoaiTB.Text = "Type";
            // 
            // lbTenCV
            // 
            this.lbTenCV.AutoSize = true;
            this.lbTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCV.ForeColor = System.Drawing.Color.Black;
            this.lbTenCV.Location = new System.Drawing.Point(26, 25);
            this.lbTenCV.Name = "lbTenCV";
            this.lbTenCV.Size = new System.Drawing.Size(82, 22);
            this.lbTenCV.TabIndex = 3;
            this.lbTenCV.Text = "Massage";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 55);
            this.panel1.TabIndex = 4;
            // 
            // iconXmark
            // 
            this.iconXmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.iconXmark.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconXmark.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconXmark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.iconXmark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.iconXmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconXmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconXmark.ForeColor = System.Drawing.Color.Transparent;
            this.iconXmark.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.iconXmark.IconColor = System.Drawing.Color.Black;
            this.iconXmark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconXmark.IconSize = 20;
            this.iconXmark.Location = new System.Drawing.Point(164, 0);
            this.iconXmark.Name = "iconXmark";
            this.iconXmark.Size = new System.Drawing.Size(25, 55);
            this.iconXmark.TabIndex = 5;
            this.iconXmark.UseVisualStyleBackColor = false;
            this.iconXmark.Click += new System.EventHandler(this.iconXmark_Click);
            // 
            // ThongBaoCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconXmark);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTenCV);
            this.Controls.Add(this.lbLoaiTB);
            this.Name = "ThongBaoCon";
            this.Size = new System.Drawing.Size(189, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoaiTB;
        private System.Windows.Forms.Label lbTenCV;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconXmark;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
