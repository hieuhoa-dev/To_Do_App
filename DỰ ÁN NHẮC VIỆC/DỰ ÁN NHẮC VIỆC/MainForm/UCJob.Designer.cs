namespace DỰ_ÁN_NHẮC_VIỆC
{
    partial class UCJob
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
            this.cbJob = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.ctnsControlCV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsSua = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.ctnsControlCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbJob
            // 
            this.cbJob.AutoSize = true;
            this.cbJob.Location = new System.Drawing.Point(20, 13);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(22, 21);
            this.cbJob.TabIndex = 0;
            this.cbJob.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnInfo
            // 
            this.btnInfo.ContextMenuStrip = this.ctnsControlCV;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(433, 42);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Làm winform";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ctnsControlCV
            // 
            this.ctnsControlCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctnsControlCV.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctnsControlCV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsSua,
            this.ctmsXoa,
            this.toolStripSeparator1});
            this.ctnsControlCV.Name = "ctnsControlCV";
            this.ctnsControlCV.Size = new System.Drawing.Size(116, 74);
            // 
            // ctmsSua
            // 
            this.ctmsSua.BackColor = System.Drawing.SystemColors.Control;
            this.ctmsSua.ForeColor = System.Drawing.Color.Black;
            this.ctmsSua.Name = "ctmsSua";
            this.ctmsSua.Size = new System.Drawing.Size(115, 32);
            this.ctmsSua.Text = "Sửa";
            this.ctmsSua.Click += new System.EventHandler(this.ctmsSua_Click);
            // 
            // ctmsXoa
            // 
            this.ctmsXoa.Name = "ctmsXoa";
            this.ctmsXoa.Size = new System.Drawing.Size(115, 32);
            this.ctmsXoa.Text = "Xóa";
            this.ctmsXoa.Click += new System.EventHandler(this.ctmsXoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.panel1);
            this.Name = "Job";
            this.Size = new System.Drawing.Size(465, 45);
            this.panel1.ResumeLayout(false);
            this.ctnsControlCV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip ctnsControlCV;
        private System.Windows.Forms.ToolStripMenuItem ctmsSua;
        private System.Windows.Forms.ToolStripMenuItem ctmsXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnInfo;
    }
}
