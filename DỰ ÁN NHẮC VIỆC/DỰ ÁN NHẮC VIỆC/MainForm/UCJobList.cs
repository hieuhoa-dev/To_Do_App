using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using DataAccess;


namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class UCJobList : UserControl
    {
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        List<Job> jobCurrent = new List<Job>();
        JobDA dscv;

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


        enum MenuChucNang
        {
            Xoa = 0,
            HoanThanh = 1
        }
        int ChucNang;
        public UCJobList(DateTime date, JobDA dscv)
        {
            InitializeComponent();
            this.Date = date;
            this.dscv = dscv;
            SetupPanel();
            ShowJobByDay();
            ChucNang = -1;
        }

        public UCJobList(JobDA dscv, int ChucNang)
        {
            InitializeComponent();
            this.dscv = dscv;
            this.ChucNang = ChucNang;
            SetupPanel();
            ShowJobTheoChucNang();
        }


        private void SetupPanel()
        {
            fPanel.AutoScroll = true;
            fPanel.Dock = DockStyle.Fill;
            pnlJob.Controls.Add(fPanel);
        }


        void ShowJobByDay()
        {
            fPanel.Controls.Clear();
            if (dscv != null && dscv.DanhSach != null)
            {
                List<Job> toDayJob = GetJobByDay();
                for (int i = 0; i < toDayJob.Count; i++)
                {
                    UCJob aJob = new UCJob(toDayJob[i]);
                    aJob.JobClicked += ListJobClick_Click;
                    aJob.JobListLoad += ListJob_Load;
                    fPanel.Controls.Add(aJob);
                }
                jobCurrent = toDayJob;
            }
        }

        void ShowJobTheoChucNang()
        {
            fPanel.Controls.Clear();
            if (dscv != null && dscv.DanhSach != null)
            {
                List<Job> toDayJob;
                if (ChucNang == (int)MenuChucNang.Xoa)
                    toDayJob = dscv.DanhSach.Where(p => p.Delete == 1).ToList();
                else
                    toDayJob = dscv.DanhSach.Where(p => p.Delete == 0 && p.Status == 1).ToList();

                for (int i = 0; i < toDayJob.Count; i++)
                {
                    UCJob aJob = new UCJob(toDayJob[i]);
                    aJob.JobClicked += ListJobClick_Click;
                    aJob.JobListLoad += ListJobByChucNang_Load;
                    fPanel.Controls.Add(aJob);
                }
                jobCurrent = toDayJob;
            }
        }

        void ShowJobKhiTimKiem(string TenCVCanTim)
        {
            fPanel.Controls.Clear();
            if (dscv != null && dscv.DanhSach != null)
            {
                for (int i = 0; i < jobCurrent.Count; i++)
                {
                    if (jobCurrent[i].NameJob.Contains(TenCVCanTim))
                    {
                        UCJob aJob = new UCJob(jobCurrent[i]);
                        aJob.JobClicked += ListJobClick_Click;
                        if (ChucNang == -1)
                        {
                            aJob.JobListLoad += ListFindTen_Load;
                        }
                        if (ChucNang == 0)
                            aJob.JobListLoad += ListFindTenDelete_Load;
                        if (ChucNang == 1)
                        {
                            aJob.JobListLoad += ListFindTenComplete_Load;
                        }
                        fPanel.Controls.Add(aJob);
                    }
                }
            }
        }

        //Các sự kiện Load
        void ListJob_Load(object sender, EventArgs e)
        {
            ShowJobByDay();
        }
        void ListJobByChucNang_Load(object sender, EventArgs e)
        {
            ShowJobTheoChucNang();
        }
        void ListFindTen_Load(object sender, EventArgs e)
        {
            jobCurrent = GetJobByDay();
            ShowJobKhiTimKiem(txtTenCV.Text);

        }
        void ListFindTenDelete_Load(object sender, EventArgs e)
        {
            jobCurrent = dscv.DanhSach.Where(p => p.Delete == 1).ToList();
            ShowJobKhiTimKiem(txtTenCV.Text);
        }

        void ListFindTenComplete_Load(object sender, EventArgs e)
        {
            jobCurrent = dscv.DanhSach.Where(p => p.Delete == 0 && p.Status == 1).ToList();
            ShowJobKhiTimKiem(txtTenCV.Text);
        }

        private void txtTenCV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenCV.Text != " TÌM CÔNG VIỆC...")
            {
                ShowJobKhiTimKiem(txtTenCV.Text);
            }
            if (txtTenCV.Text == "")
            {
                return;
            }
        }

        List<Job> GetJobByDay()
        {
            return dscv.DanhSach.Where(p => p.ToDate.Year == Date.Year
                && p.ToDate.Month == Date.Month
                && p.ToDate.Day == Date.Day
                && p.Delete == 0).ToList(); // Lấy ds chưa xóa
        }


        private void txtTenCV_Enter(object sender, EventArgs e)
        {
            if (txtTenCV.Text == " TÌM CÔNG VIỆC...")
            {
                txtTenCV.Text = "";
                txtTenCV.ForeColor = Color.Black;
            }
        }

        private void txtTenCV_Leave(object sender, EventArgs e)
        {
            if (txtTenCV.Text == "")
            {
                txtTenCV.Text = " TÌM CÔNG VIỆC...";
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
    }
}
