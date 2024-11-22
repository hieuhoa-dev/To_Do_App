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
            this.iconFlat = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new System.Windows.Forms.Button();
            this.ctnsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctnsHavedDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.khôiPhụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaVĩnhViễnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.ctnsDelete.SuspendLayout();
            this.ctnsHavedDelete.SuspendLayout();
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
            this.cbJob.CheckedChanged += new System.EventHandler(this.cbJob_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconFlat);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 45);
            this.panel1.TabIndex = 2;
            // 
            // iconFlat
            // 
            this.iconFlat.BackColor = System.Drawing.Color.Transparent;
            this.iconFlat.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconFlat.FlatAppearance.BorderSize = 0;
            this.iconFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFlat.ForeColor = System.Drawing.Color.Gray;
            this.iconFlat.IconChar = FontAwesome.Sharp.IconChar.Flag;
            this.iconFlat.IconColor = System.Drawing.Color.Black;
            this.iconFlat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFlat.IconSize = 25;
            this.iconFlat.Location = new System.Drawing.Point(411, 0);
            this.iconFlat.Name = "iconFlat";
            this.iconFlat.Size = new System.Drawing.Size(34, 45);
            this.iconFlat.TabIndex = 3;
            this.iconFlat.UseVisualStyleBackColor = false;
            this.iconFlat.Click += new System.EventHandler(this.iconFlat_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.ContextMenuStrip = this.ctnsDelete;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(403, 42);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Làm winform";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ctnsDelete
            // 
            this.ctnsDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctnsDelete.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctnsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsXoa,
            this.toolStripSeparator1});
            this.ctnsDelete.Name = "ctnsControlCV";
            this.ctnsDelete.Size = new System.Drawing.Size(116, 42);
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
            // ctnsHavedDelete
            // 
            this.ctnsHavedDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctnsHavedDelete.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctnsHavedDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khôiPhụcToolStripMenuItem,
            this.xóaVĩnhViễnToolStripMenuItem});
            this.ctnsHavedDelete.Name = "ctnsHavedDelete";
            this.ctnsHavedDelete.Size = new System.Drawing.Size(241, 101);
            // 
            // khôiPhụcToolStripMenuItem
            // 
            this.khôiPhụcToolStripMenuItem.Name = "khôiPhụcToolStripMenuItem";
            this.khôiPhụcToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.khôiPhụcToolStripMenuItem.Text = "Khôi phục";
            this.khôiPhụcToolStripMenuItem.Click += new System.EventHandler(this.khôiPhụcToolStripMenuItem_Click);
            // 
            // xóaVĩnhViễnToolStripMenuItem
            // 
            this.xóaVĩnhViễnToolStripMenuItem.Name = "xóaVĩnhViễnToolStripMenuItem";
            this.xóaVĩnhViễnToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.xóaVĩnhViễnToolStripMenuItem.Text = "Xóa vĩnh viễn";
            this.xóaVĩnhViễnToolStripMenuItem.Click += new System.EventHandler(this.xóaVĩnhViễnToolStripMenuItem_Click);
            // 
            // UCJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.panel1);
            this.Name = "UCJob";
            this.Size = new System.Drawing.Size(459, 45);
            this.panel1.ResumeLayout(false);
            this.ctnsDelete.ResumeLayout(false);
            this.ctnsHavedDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip ctnsDelete;
        private System.Windows.Forms.ToolStripMenuItem ctmsXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnInfo;
        private FontAwesome.Sharp.IconButton iconFlat;
        private System.Windows.Forms.ContextMenuStrip ctnsHavedDelete;
        private System.Windows.Forms.ToolStripMenuItem khôiPhụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaVĩnhViễnToolStripMenuItem;
    }
}
