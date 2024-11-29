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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        int BienLuuMucDo;
        public UCJobChild(Job jobItem, List<JobChild> ListJobchild)
        {
            InitializeComponent();

            this.JobItem = jobItem;
            this.ListJobchild = ListJobchild;

            ShowInfo();
        }

        //Load công việc
        public void ShowInfo()
        {
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
            this.toolTipShowProgress.SetToolTip(this.progressBarJob, progressBarJob.Value.ToString() + "%");
        }


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
            // Tạo mặt nạ cho txtName
            if (txtName.Text == "Nhập tên công việc")
            {
                txtName.Text = string.Empty;
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            // Tạo mặt nạ cho txtName
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Text = "Nhập tên công việc";
                txtName.ForeColor = Color.DarkGray;
            }
        }

        // Event khi thay đổi sẽ load danh sách, gửi qua main Form
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
            //Truyền sự kiên e vào JobLoad
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
            // Kiểm tra ngày BD nhỏ hơn ngày KT
            if(dtpNgayBD.Value > dtpNgayKT.Value)
                dtpNgayKT.Value = dtpNgayBD.Value;
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
            if (KiemTraNgayThang() && nupGioBD.Value > nupGioKT.Value) 
            {
                nupGioKT.Value = nupGioBD.Value;
                //Gán lại giá trị các thời gian KT
                dtpNgayKT.Value = jobItem.FromDate;
                nupGioKT.Value = jobItem.FromDate.Hour;
                nupPhutKT.Value = jobItem.FromDate.Minute;
            }
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
            if (KiemTraNgayThang() && nupGioBD.Value == nupGioKT.Value && nupPhutBD.Value >= nupPhutKT.Value)
            {
                nupPhutKT.Value = nupPhutBD.Value;
                jobItem.FromDate = jobItem.FromDate.AddMinutes(5);
                //Gán lại giá trị các thời gian KT
                dtpNgayKT.Value = jobItem.FromDate;
                nupGioKT.Value = jobItem.FromDate.Hour;
                nupPhutKT.Value = jobItem.FromDate.Minute;
            }

            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
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

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            jobItem.FromDate = dtpNgayKT.Value;
            // Kiểm tra ngày BD nhỏ hơn ngày KT
            if (dtpNgayBD.Value > dtpNgayKT.Value)
                dtpNgayBD.Value = dtpNgayKT.Value;
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
            if (KiemTraNgayThang() && nupGioBD.Value > nupGioKT.Value)
            {
                nupGioBD.Value = nupGioKT.Value;
                //Gán lại giá trị các thời gian BD
                dtpNgayBD.Value = jobItem.ToDate;
                nupGioBD.Value = jobItem.ToDate.Hour;
                nupPhutBD.Value = jobItem.ToDate.Minute;
            }
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
            if (KiemTraNgayThang() && nupGioBD.Value == nupGioKT.Value && nupPhutBD.Value >= nupPhutKT.Value)
            {
                nupPhutBD.Value = nupPhutKT.Value;
                jobItem.ToDate = jobItem.ToDate.AddMinutes(-5);
                //Gán lại giá trị các thời gian KT
                dtpNgayBD.Value = jobItem.ToDate;
                nupGioBD.Value = jobItem.ToDate.Hour;
                nupPhutBD.Value = jobItem.ToDate.Minute;
            }
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
        }


        private void dgvListJobChild_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện khi ấn vào nút Xóa
            if (e.RowIndex >= 0
                && e.ColumnIndex == dgvListJobChild.Columns["DeleteColumn"].Index
                && !dgvListJobChild.Rows[e.RowIndex].IsNewRow) // Bỏ dòng mới
            {
                JobChildBL jobChildBL = new JobChildBL();
                JobChild jobChild = ListJobchild[e.RowIndex];

                // Xóa hàng trong DataGridView
                dgvListJobChild.Rows.RemoveAt(e.RowIndex);

                //Xóa trong ds cục bộ 
                ListJobchild.Remove(jobChild);

                // Xóa hàng trong Sql
                jobChildBL.Delete(jobChild);
            }
            LoadProgress();
        }


        private void dgvListJobChild_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu dòng đang xử lý là "New Row"
            if (dgvListJobChild.Rows[e.RowIndex].IsNewRow)
                return;

            var row = dgvListJobChild.Rows[e.RowIndex]; // Lấy dữ liệu từ dòng
            JobChildBL jobChildBL = new JobChildBL();

            // Kiểm tra nếu hàng đã tồn tại trong danh sách ListJobchild
            if (e.RowIndex < ListJobchild.Count)
            {
                // Cập nhật hàng cũ
                var jobChild = ListJobchild[e.RowIndex];
                jobChild.Name = row.Cells["dtgvName"].Value?.ToString();
                jobChild.Status = bool.TryParse(row.Cells["dtgvStatus"].Value?.ToString(), out bool status) && status ? 1 : 0;

                jobChildBL.Update(jobChild); // Cập nhật vào cơ sở dữ liệu
            }
            else
            {
                // Thêm hàng mới
                var jobChildNew = new JobChild
                {
                    JobID = jobItem.ID,
                    Name = row.Cells["dtgvName"].Value?.ToString(),
                    Status = bool.TryParse(row.Cells["dtgvStatus"].Value?.ToString(), out bool status) && status ? 1 : 0
                };

                jobChildBL.Insert(jobChildNew); // Thêm mới vào cơ sở dữ liệu
            }
            LoadProgress();
        }
    }
}
