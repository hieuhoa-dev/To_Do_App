using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class UCJobChild : UserControl
    {
        private Job jobItem;
        public Job JobItem
        {
            get { return jobItem; }
            set { jobItem = value; }
        }

        private List<JobChild> ListJobchild;

        public UCJobChild(Job jobItem, List<JobChild> ListJobchild)
        {
            InitializeComponent();

            this.JobItem = jobItem;
            this.ListJobchild = ListJobchild;

            ShowInfo();
        }

        public void ShowInfo()
        {
            //if (JobItem == null)
            //{
            //    return;
            //}
            txtName.Text = jobItem.NameJob;
            txtNotes.Text = jobItem.Notes;
            if (jobItem.Status == 1)
            {
                cbTrangThai.Checked = true;
            }
            else cbTrangThai.Checked = false;

            foreach (JobChild jobChild in ListJobchild)
            {
                // Thêm hàng mới
                int index = dgvListJobChild.Rows.Add();

                // Gán giá trị cho các ô trong hàng
                dgvListJobChild.Rows[index].Cells["dtgvStatus"].Value = jobChild.Status; // Đặt trạng thái Checked nếu Status == 1
                dgvListJobChild.Rows[index].Cells["dtgvName"].Value = jobChild.Name;
            }

            LoadMucDo();
            LoadProgress();
            LoadNgay();
        }

        void LoadProgress()
        {
            progressBarJob.Value = 0;
            int SoCVHoanThanh = 0;
            int Tong = ListJobchild.Count;
            if (Tong > 0) // Kiểm tra tránh chia cho 0
            {
                foreach (JobChild jobChild in ListJobchild)
                {
                    if (jobChild.Status == 1)
                    {
                        SoCVHoanThanh++;
                    }
                }
                // Tính tỷ lệ hoàn thành
                progressBarJob.Value = (int)((double)SoCVHoanThanh / Tong * 100);
            }
            else
            {
                progressBarJob.Value = 0; // Nếu không có công việc nào, đặt giá trị progressBar về 0
            }
        }

        int BienLuuMucDo;
        void LoadMucDo()
        {
            if (jobItem.LevelJob == 1)
            {
                iconFlat.IconColor = Color.FromArgb(174, 68, 90);
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                iconFlat.IconColor = Color.Black;
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            }
            BienLuuMucDo = jobItem.LevelJob;
        }
        void LoadNgay()
        {
            dtpNgayBD.Value = jobItem.ToDate;
            nupGioBD.Value = jobItem.ToDate.Hour;
            nupPhutBD.Value = jobItem.ToDate.Minute;

            dtpNgayKT.Value = jobItem.FromDate;
            nupGioKT.Value = jobItem.FromDate.Hour;
            nupPhutKT.Value = jobItem.FromDate.Minute;

            // Nếu thời gian bắt đầu lớn hơn hoặc bằng thời gian kết thúc
            if (jobItem.FromDate >= jobItem.ToDate)
            {
                // Điều chỉnh lại thời gian bắt đầu: cộng thêm 5 phút vào thời gian kết thúc
                jobItem.FromDate = jobItem.ToDate.AddMinutes(5);
            }
        }
        private void iconFlat_Click(object sender, EventArgs e)
        {
            if (BienLuuMucDo == 0)
            {
                iconFlat.IconColor = Color.FromArgb(174, 68, 90);
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Solid;
                jobItem.LevelJob = 1;
                BienLuuMucDo = 1;
            }
            else
            {
                iconFlat.IconColor = Color.Black;
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Auto;
                jobItem.LevelJob = 0;
                BienLuuMucDo = 0;
            }
            CapNhatThongTin(sender, e);
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nhập tên công việc")
            {
                txtName.Text = string.Empty;
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Text = "Nhập tên công việc";
                txtName.ForeColor = Color.DarkGray;
            }
        }

        public event EventHandler JobLoad;
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "Nhập tên công việc")
            {
                jobItem.NameJob = txtName.Text; // Lưu dữ liệu chỉ khi là nội dung hợp lệ
                CapNhatThongTin(sender, e);
            }
        }

        private void cbTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTrangThai.Checked)
            {
                jobItem.Status = 1;
            }
            else jobItem.Status = 0;
            CapNhatThongTin(sender, e);
        }

        void CapNhatThongTin(object sender, EventArgs e)
        {
            JobBL jobBL = new JobBL();
            // Cập nhật dữ liệu trong bảng
            jobBL.Update(jobItem);
            JobLoad?.Invoke(this, e);
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            jobItem.Notes = txtNotes.Text;
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            jobItem.ToDate = dtpNgayBD.Value;
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }

        private void nupGioBD_ValueChanged(object sender, EventArgs e)
        {
            jobItem.ToDate = new DateTime(
                jobItem.ToDate.Year,
                jobItem.ToDate.Month,
                jobItem.ToDate.Day,
                (int)nupGioBD.Value, // Lấy giờ từ NumericUpDown
                jobItem.ToDate.Minute,
                jobItem.ToDate.Second
            );
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }

        private void nupPhutBD_ValueChanged(object sender, EventArgs e)
        {
            jobItem.ToDate = new DateTime(
               jobItem.ToDate.Year,
               jobItem.ToDate.Month,
               jobItem.ToDate.Day,
               jobItem.ToDate.Hour,
               (int)nupPhutBD.Value, // Lấy giờ từ NumericUpDown
               jobItem.ToDate.Second
             );
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            jobItem.FromDate = dtpNgayKT.Value;
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }

        private void nupGioKT_ValueChanged(object sender, EventArgs e)
        {
            jobItem.FromDate = new DateTime(
               jobItem.FromDate.Year,
               jobItem.FromDate.Month,
               jobItem.FromDate.Day,
               (int)nupGioKT.Value, // Lấy giờ từ NumericUpDown
               jobItem.FromDate.Minute,
               jobItem.FromDate.Second
           );
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }

        private void nupPhutKT_ValueChanged(object sender, EventArgs e)
        {
            jobItem.FromDate = new DateTime(
               jobItem.FromDate.Year,
               jobItem.FromDate.Month,
               jobItem.FromDate.Day,
               jobItem.FromDate.Hour,
               (int)nupPhutKT.Value, // Lấy giờ từ NumericUpDown
               jobItem.FromDate.Second
             );
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }
    }
}
