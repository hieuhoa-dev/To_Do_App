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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dtpJob
            // 
            this.dtpJob.Location = new System.Drawing.Point(27, 24);
            this.dtpJob.Name = "dtpJob";
            this.dtpJob.Size = new System.Drawing.Size(285, 26);
            this.dtpJob.TabIndex = 0;
            this.dtpJob.ValueChanged += new System.EventHandler(this.dtpJob_ValueChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(361, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlJob
            // 
            this.pnlJob.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJob.Location = new System.Drawing.Point(0, 77);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(469, 730);
            this.pnlJob.TabIndex = 2;
            // 
            // JobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlJob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpJob);
            this.Name = "JobList";
            this.Size = new System.Drawing.Size(469, 807);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlJob;
    }
}
