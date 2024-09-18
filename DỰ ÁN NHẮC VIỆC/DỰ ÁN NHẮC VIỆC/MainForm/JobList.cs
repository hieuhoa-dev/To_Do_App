using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class JobList : UserControl
    {
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private DSCongViec cv;

        public DSCongViec CongViec
        {
            get { return cv; }
            set { cv = value; }
        }

        public JobList(DateTime date,DSCongViec cv)
        {
            InitializeComponent();
            this.Date = date;
            this.CongViec = cv;

            FlowLayoutPanel fPanel = new FlowLayoutPanel();
            fPanel.Width = fpnlJob.Width;
            fPanel.Height = fpnlJob.Height;
            fpnlJob.Controls.Add(fPanel);

            if (CongViec != null && CongViec.ListItemPlan != null)
            {
                for (int i = 0; i < CongViec.ListItemPlan.Count; i++)
                {
                    Job aJob = new Job(CongViec.ListItemPlan[i]);
                    fPanel.Controls.Add(aJob);

                }
            }

            dtpJob.Value = Date;
        }

        public void ThemJob()
        {
            Job job = new Job();
            fpnlJob.Controls.Add(job);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            fpnlJob.Controls.Add(job);
        }
    }
}
