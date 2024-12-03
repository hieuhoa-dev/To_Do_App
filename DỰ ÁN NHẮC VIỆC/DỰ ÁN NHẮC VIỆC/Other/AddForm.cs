using System;
using System.Windows.Forms;
using System.Xml.Linq;

using DataAccess;
using BusinessLogic;
using System.Reflection;
using DỰ_ÁN_NHẮC_VIỆC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;

namespace Other
{
    public partial class AddForm : Form
    {
        private Job job; // Biến cục bộ
        public event EventHandler btnSaveClick; // Truyền sự kiện
        private DateTime NgayBD;
        private DateTime NgayKT;
        public AddForm()
        {
            InitializeComponent();

            cmbMucDo.SelectedIndex = 0;
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            NgayBD = DateTime.Today;
            NgayKT = NgayBD.AddMinutes(5);

            dtpNgayBD.Value = NgayBD;
            nupGioBD.Value = NgayBD.Hour;
            nupPhutBD.Value = NgayBD.Minute;

            dtpNgayKT.Value = NgayKT;
            nupGioKT.Value = NgayKT.Hour;
            nupPhutKT.Value = NgayKT.Minute;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddJobToSql();
            btnSaveClick?.Invoke(this, e);
            this.Close();
        }

        void AddJobToSql()
        {
            int result = InsertJob();
            InsertJobChild(result);
            if (result > 0) // Nếu thêm thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Thêm dữ liệu thành công");
            }
        }

        public int InsertJob()
        {

            //Khai báo đối tượng Job từ tầng DataAccess
            job = new Job();
            job.ID = 0;
            // Kiểm tra nếu các ô nhập khác rỗng
            if (txtTen.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {   
                job.NameJob = txtTen.Text;
                job.ToDate = NgayBD;
                job.FromDate = NgayKT;

                //Trang thái
                if (chbJob.Checked)
                    job.Status = 1; // Đã hoàn thành
                else job.Status = 0; // Chưa check

                job.Category = txtTheLoai.Text;

                if (cmbMucDo.SelectedIndex == -1) // Tự đồng chọn None
                    cmbMucDo.SelectedIndex = 0;

                if (cmbMucDo.SelectedIndex == 0)  // Nếu None lưu vào job
                    job.LevelJob = 0;
                else job.LevelJob = 1; //Nếu Important lưu 

                job.Notes = txtNotes.Text;

                job.Delete = 0;
                job.TimeDelete = DateTime.Now;
                JobBL jobBL = new JobBL();
                // Chèn dữ liệu vào bảng
                return jobBL.Insert(job);
            }
            return -1;
        }

        public void InsertJobChild(int JobID)
        {
            //Khai báo đối tượng JobChild từ tầng DataAccess
            if (dtgvJobChild.Rows.Count > 1) // Kiểm tra có ít nhất 1 hàng
            {
                foreach (DataGridViewRow row in dtgvJobChild.Rows)
                {
                    // Bỏ qua hàng "New Row" (hàng trống được tạo tự động)
                    if (row.IsNewRow) continue;

                    JobChild jobChild = new JobChild();
                    jobChild.ID = 0;
                    jobChild.Name = row.Cells["clJobChild"].Value?.ToString(); // Lấy tên công việc
                    jobChild.Status = row.Cells["clStatus"].Value != null && (bool)row.Cells["clStatus"].Value ? 1 : 0;// Lấy trạng thái                                                                                                    
                    jobChild.JobID = JobID;
                    JobChildBL jobChildBL = new JobChildBL();
                    jobChildBL.Insert(jobChild);
                }
            }
        }

        private void dgvListJobChild_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvJobChild.Columns["clRemove"].Index
              && !dtgvJobChild.Rows[e.RowIndex].IsNewRow)
            {
                dtgvJobChild.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            //Kiểm tra ngày KT
            if (dtpNgayBD.Value > dtpNgayKT.Value)
                dtpNgayKT.Value = dtpNgayBD.Value;
            //Gán ngày BD
            NgayBD = new DateTime(
              dtpNgayBD.Value.Year,
              dtpNgayBD.Value.Month,
              dtpNgayBD.Value.Day,
              NgayBD.Hour,
              NgayBD.Minute,
              NgayBD.Second);
        }

        private void nupGioBD_ValueChanged(object sender, EventArgs e)
        {
            //Gán ngày BD
            NgayBD = new DateTime(
              NgayBD.Year,
              NgayBD.Month,
              NgayBD.Day,
              (int)nupGioBD.Value, // Lấy giờ từ NumericUpDown
              NgayBD.Minute,
              NgayBD.Second
              );
            //Kiểm tra ngày KT
            if (KiemTraNgayThang() && nupGioBD.Value > nupGioKT.Value)
            {
                nupGioKT.Value = nupGioBD.Value;
                //Gán lại giá trị các thời gian KT
                dtpNgayKT.Value = NgayKT;
                nupGioKT.Value = NgayKT.Hour;
                nupPhutKT.Value = NgayKT.Minute;
            }

        }

        private void nupPhutBD_ValueChanged(object sender, EventArgs e)
        {
            // Gán ngày BD
            NgayBD = new DateTime(
              NgayBD.Year,
              NgayBD.Month,
              NgayBD.Day,
              NgayBD.Hour, // Lấy giờ từ NumericUpDown
              (int)nupPhutBD.Value,
              NgayBD.Second
              );
            //Kiểm tra ngày KT
            if (KiemTraNgayThang() && nupGioBD.Value == nupGioKT.Value && nupPhutBD.Value >= nupPhutKT.Value)
            {
                nupPhutKT.Value = nupPhutBD.Value;
                NgayKT = NgayKT.AddMinutes(5);
                //Gán lại giá trị các thời gian KT
                dtpNgayKT.Value = NgayKT;
                nupGioKT.Value = NgayKT.Hour;
                nupPhutKT.Value = NgayKT.Minute;
            }
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            // Gán ngày BD
            if (dtpNgayBD.Value > dtpNgayKT.Value)
                dtpNgayBD.Value = dtpNgayKT.Value;
            //Kiểm tra ngày KT
            NgayKT = new DateTime(
                dtpNgayKT.Value.Year,
                dtpNgayKT.Value.Month,
                dtpNgayKT.Value.Day,
                NgayKT.Hour,
                NgayKT.Minute,
                NgayKT.Second
                );
        }

        private void nupGioKT_ValueChanged(object sender, EventArgs e)
        {
            //Gán ngày KT
            NgayKT = new DateTime(
             NgayKT.Year,
             NgayKT.Month,
             NgayKT.Day,
             (int)nupGioKT.Value, // Lấy giờ từ NumericUpDown
             NgayKT.Minute,
             NgayKT.Second
             );
            //Kiểm tra ngày BD
            if (KiemTraNgayThang() && nupGioBD.Value > nupGioKT.Value)
            {
                nupGioBD.Value = nupGioKT.Value;
                //Gán lại giá trị các thời gian KT
                dtpNgayBD.Value = NgayBD;
                nupGioBD.Value = NgayBD.Hour;
                nupPhutBD.Value = NgayBD.Minute;
            }

        }

        private void nupPhutKT_ValueChanged(object sender, EventArgs e)
        {
            // Gán ngày KT
            NgayKT = new DateTime(
              NgayKT.Year,
              NgayKT.Month,
              NgayKT.Day,
              NgayKT.Hour, // Lấy giờ từ NumericUpDown
              (int)nupPhutKT.Value,
              NgayKT.Second
              );
            //Kiểm tra ngày BD
            if (KiemTraNgayThang() && nupGioBD.Value == nupGioKT.Value && nupPhutBD.Value >= nupPhutKT.Value)
            {
                nupPhutBD.Value = nupPhutKT.Value;
                NgayBD = NgayBD.AddMinutes(-5);
                //Gán lại giá trị các thời gian KT
                dtpNgayBD.Value = NgayBD;
                nupGioBD.Value = NgayBD.Hour;
                nupPhutBD.Value = NgayBD.Minute;
            }
        }

        bool KiemTraNgayThang()
        {
            if (dtpNgayBD.Value.Year == dtpNgayKT.Value.Year
                && dtpNgayBD.Value.Month == dtpNgayKT.Value.Month
                 && dtpNgayBD.Value.Day == dtpNgayKT.Value.Day)
            {
                return true;
            }
            return false;
        }


    }
}

