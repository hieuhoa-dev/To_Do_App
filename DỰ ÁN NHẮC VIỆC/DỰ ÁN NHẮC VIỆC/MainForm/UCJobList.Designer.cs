namespace DỰ_ÁN_NHẮC_VIỆC
{
    partial class UCJobList
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
            this.pnlJob = new System.Windows.Forms.Panel();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // pnlJob
            // 
            this.pnlJob.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJob.Location = new System.Drawing.Point(0, 45);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(469, 762);
            this.pnlJob.TabIndex = 2;
            // 
            // txtTenCV
            // 
            this.txtTenCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenCV.Location = new System.Drawing.Point(0, 0);
            this.txtTenCV.Multiline = true;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(410, 45);
            this.txtTenCV.TabIndex = 22;
            this.txtTenCV.Text = " TÌM CÔNG VIỆC...";
            this.txtTenCV.TextChanged += new System.EventHandler(this.txtTenCV_TextChanged);
            this.txtTenCV.Enter += new System.EventHandler(this.txtTenCV_Enter);
            this.txtTenCV.Leave += new System.EventHandler(this.txtTenCV_Leave);
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.Color.DimGray;
            this.iconSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconSearch.FlatAppearance.BorderSize = 0;
            this.iconSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconSearch.ForeColor = System.Drawing.Color.Transparent;
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconSearch.IconColor = System.Drawing.Color.White;
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.IconSize = 25;
            this.iconSearch.Location = new System.Drawing.Point(410, 0);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(59, 45);
            this.iconSearch.TabIndex = 4;
            this.iconSearch.UseVisualStyleBackColor = false;
            // 
            // UCJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.pnlJob);
            this.Name = "UCJobList";
            this.Size = new System.Drawing.Size(469, 807);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.TextBox txtTenCV;
        private FontAwesome.Sharp.IconButton iconSearch;
    }
}
