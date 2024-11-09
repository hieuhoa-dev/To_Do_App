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

        DSCongViec dscv;
        public JobList()
        {
            InitializeComponent();
        }
        public JobList(DateTime date, DSCongViec dscv)
        {
            InitializeComponent();
            this.Date = date;
            this.dscv = dscv;
            fPanel.AutoScroll = true;
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);
            dtpJob.Value = date;
            ShowJobByDay(date);
        }

        public void ThemJob()
        {
            Job job = new Job();
            pnlJob.Controls.Add(job);
        }

        public void AddJob(CongViec cv)
        {
            Job aJob = new Job(cv);
            aJob.JobClicked += ListJobClick_Click;
            cv.NameJob = txtTenCV.Text;

            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleted;


            fPanel.Controls.Add(aJob);
        }


        void ShowJobByDay(DateTime date)
        {
            fPanel.Controls.Clear();
            if (dscv != null && dscv.DanhSach != null)
            {
                List<CongViec> toDayJob = GetJobByDay(date);
                for (int i = 0; i < toDayJob.Count; i++)
                {
                    Job aJob = new Job(toDayJob[i]);
                    aJob.JobClicked += ListJobClick_Click;
                    fPanel.Controls.Add(aJob);

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
            dscv.DanhSach.Remove(congViec);
        }

        private void dtpJob_ValueChanged(object sender, EventArgs e)
        {

            ShowJobByDay((sender as DateTimePicker).Value);
        }

        List<CongViec> GetJobByDay(DateTime date)
        {
            return dscv.DanhSach.Where(p => p.ToDate.Year == date.Year && p.ToDate.Month == date.Month && p.ToDate.Day == date.Day).ToList();
        }


        private void txtTenCV_Enter(object sender, EventArgs e)
        {
            if (txtTenCV.Text == "  + Add tasks")
            {
                txtTenCV.Text = "";
                txtTenCV.ForeColor = Color.Black;
            }
        }

        private void txtTenCV_Leave(object sender, EventArgs e)
        {
            if (txtTenCV.Text == "")
            {
                txtTenCV.Text = "  + Add tasks";
                txtTenCV.ForeColor = Color.DimGray;
            }
        }
        public delegate void JobClickEventHandler(object sender, EventArgs e, CongViec cv);

        // Sự kiện JobClicked với kiểu delegate đã định nghĩa
        public event JobClickEventHandler ListJobClick;

        private void ListJobClick_Click(object sender, EventArgs e, CongViec cv)
        {
            ListJobClick?.Invoke(this, e,cv);

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text == "  + Add tasks" || txtTenCV.Text.Trim() == "")
                return;
            CongViec cv = new CongViec() { ToDate = dtpJob.Value };
            dscv.Them(cv);
            AddJob(cv);
            txtTenCV.Text = "  + Add tasks";
            txtTenCV.ForeColor = Color.DimGray;
        }
    }
}
