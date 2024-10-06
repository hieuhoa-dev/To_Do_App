namespace DỰ_ÁN_NHẮC_VIỆC
{
    partial class JobList
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
            this.dtpJob = new System.Windows.Forms.DateTimePicker();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpJob
            // 
            this.dtpJob.Location = new System.Drawing.Point(79, 3);
            this.dtpJob.Name = "dtpJob";
            this.dtpJob.Size = new System.Drawing.Size(285, 26);
            this.dtpJob.TabIndex = 0;
            this.dtpJob.Visible = false;
            this.dtpJob.ValueChanged += new System.EventHandler(this.dtpJob_ValueChanged);
            // 
            // pnlJob
            // 
            this.pnlJob.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJob.Location = new System.Drawing.Point(0, 77);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(469, 730);
            this.pnlJob.TabIndex = 2;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.ForeColor = System.Drawing.Color.Gray;
            this.txtTenCV.Location = new System.Drawing.Point(3, 35);
            this.txtTenCV.Multiline = true;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(448, 36);
            this.txtTenCV.TabIndex = 22;
            this.txtTenCV.Text = "  + Add tasks";
            this.txtTenCV.Enter += new System.EventHandler(this.txtTenCV_Enter);
            this.txtTenCV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenCV_KeyDown);
            this.txtTenCV.Leave += new System.EventHandler(this.txtTenCV_Leave);
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.pnlJob);
            this.Controls.Add(this.dtpJob);
            this.Name = "JobList";
            this.Size = new System.Drawing.Size(469, 807);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpJob;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.TextBox txtTenCV;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Button button1;
    }
}
