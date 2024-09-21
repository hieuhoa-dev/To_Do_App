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
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private DSCongViec dscv;

        public DSCongViec DSCongViec
        {
            get { return dscv; }
            set { dscv = value; }
        }

        public JobList(DateTime date,DSCongViec dscv)
        {
            InitializeComponent();
            this.Date = date;
            this.DSCongViec = dscv;
  
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            dtpJob.Value = Date;
        }

        public void ThemJob()
        {
            Job job = new Job();
            pnlJob.Controls.Add(job);
        }

        public void AddJob(CongViec cv)
        {
            Job aJob = new Job(cv);
            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleted;


            fPanel.Controls.Add(aJob);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CongViec cv = new CongViec() { Date = dtpJob.Value};
            //DSCongViec.ListItemPlan.Add(cv);
            AddJob(cv);
        }

        void ShowJobByDay(DateTime date)
        {
            fPanel.Controls.Clear();
            if (DSCongViec != null && DSCongViec.ListItemPlan != null)
            {
                List<CongViec> toDayJob = GetJobByDay(date);
                for (int i = 0; i < toDayJob.Count; i++)
                {
                    AddJob(toDayJob[i]);

                }
            }
        }

        void aJob_Edited(object sender, EventArgs e)
        {

        }

        void aJob_Deleted(object sender, EventArgs e)
        {
            Job uc = sender as Job;
            CongViec congViec = uc.JobItem;

            fPanel.Controls.Remove(uc);
            DSCongViec.ListItemPlan.Remove(congViec);
        }

        private void dtpJob_ValueChanged(object sender, EventArgs e)
        {

            ShowJobByDay((sender as DateTimePicker).Value);
        }

        List<CongViec> GetJobByDay(DateTime date)
        {
            return DSCongViec.ListItemPlan.Where(p=>p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
    }
}
