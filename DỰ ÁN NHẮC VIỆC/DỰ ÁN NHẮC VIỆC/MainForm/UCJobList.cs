using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataAccess;


namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class UCJobList : UserControl
    {
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        JobDA dscv;

        enum MenuChucNang
        {
            Xoa = 0,
            HoanThanh = 1
        }

        public UCJobList(JobDA dscv, int ChucNang)
        {
            InitializeComponent();
            this.dscv = dscv;
            fPanel.AutoScroll = true;
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);
            ShowJobTheoChucNang(ChucNang);
        }
        public UCJobList(DateTime date, JobDA dscv)
        {
            InitializeComponent();
            this.Date = date;
            this.dscv = dscv;
            fPanel.AutoScroll = true;
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);
            //dtpJob.Value = date;
            ShowJobByDay(date);
        }

        //public void ThemJob()
        //{
        //    UCJob job = new UCJob();
        //    pnlJob.Controls.Add(job);
        //}
        public event EventHandler JobChildLoad;
        public void AddJob(Job cv)
        {
            UCJob aJob = new UCJob(cv);
            aJob.JobClicked += ListJobClick_Click;
            aJob.JobListLoad += ListJob_Load;
            cv.NameJob = txtTenCV.Text;



            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleted;


            fPanel.Controls.Add(aJob);
        }

        void ListJob_Load(object sender, EventArgs e)
        {
            ShowJobByDay(Date);
        }

        void ShowJobByDay(DateTime date)
        {
            fPanel.Controls.Clear();
            if (dscv != null && dscv.DanhSach != null)
            {
                List<Job> toDayJob = GetJobByDay(date);
                for (int i = 0; i < toDayJob.Count; i++)
                {
                    UCJob aJob = new UCJob(toDayJob[i]);
                    aJob.JobClicked += ListJobClick_Click;
                    aJob.JobListLoad += ListJob_Load;
                    fPanel.Controls.Add(aJob);

                }
            }
        }

        // Lấy danh sách đã xóa: có Delete = 1
        void ShowJobTheoChucNang(int ChucNang)
        {
            fPanel.Controls.Clear();
            if (dscv != null && dscv.DanhSach != null)
            {
                List<Job> toDayJob;
                if (ChucNang == (int)MenuChucNang.Xoa)
                    toDayJob = dscv.DanhSach.Where(p => p.Delete == 1).ToList();
                else
                    toDayJob = dscv.DanhSach.Where(p => p.Status == 1).ToList();

                for (int i = 0; i < toDayJob.Count; i++)
                {
                    UCJob aJob = new UCJob(toDayJob[i]);
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
            UCJob uc = sender as UCJob;
            DataAccess.Job congViec = uc.JobItem;

            fPanel.Controls.Remove(uc);
            dscv.DanhSach.Remove(congViec);
        }

        private void dtpJob_ValueChanged(object sender, EventArgs e)
        {

            // ShowJobByDay((sender as DateTimePicker).Value);
        }

        List<DataAccess.Job> GetJobByDay(DateTime date)
        {
            return dscv.DanhSach.Where(p => p.ToDate.Year == date.Year
                && p.ToDate.Month == date.Month
                && p.ToDate.Day == date.Day
                && p.Delete == 0).ToList(); // Lấy ds chưa xóa
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
        public delegate void JobClickEventHandler(object sender, EventArgs e, DataAccess.Job cv);

        // Sự kiện JobClicked với kiểu delegate đã định nghĩa
        public event JobClickEventHandler ListJobClick;

        private void ListJobClick_Click(object sender, EventArgs e, DataAccess.Job cv)
        {
            ListJobClick?.Invoke(this, e, cv);

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text == "  + Add tasks" || txtTenCV.Text.Trim() == "")
                return;
            DataAccess.Job cv = new DataAccess.Job()/* { ToDate = dtpJob.Value }*/;
            dscv.DanhSach.Add(cv);
            AddJob(cv);
            txtTenCV.Text = "  + Add tasks";
            txtTenCV.ForeColor = Color.DimGray;
        }
    }
}
