using System;
using System.Windows.Forms;
using System.Xml.Linq;

using DataAccess;
using BusinessLogic;
using System.Reflection;
using DỰ_ÁN_NHẮC_VIỆC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Other
{
    public partial class AddForm : Form
    {

        int ChonChuNang; // 0: là tạo, 1 là lưu

        public AddForm(int chonChuNang)
        {
            InitializeComponent();
            ChonChuNang = chonChuNang;
            cmbMucDo.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler btnSaveClick; // Truyền sự kiện
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChonChuNang == 0)
                AddJobToSql();
            else
                UpdateJobToSql();
            btnSaveClick?.Invoke(this, e);

        }

        void AddJobToSql()
        {
            int result = InsertJob();
            InsertJobChild(result);
            if (result > 0) // Nếu thêm thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Thêm dữ liệu thành công");
                // Tải lại dữ liệu cho ListView
                //LoadFoodDataToListView();
            }
        }
        public int InsertJob()
        {

            //Khai báo đối tượng Job từ tầng DataAccess
            Job job = new Job();
            job.ID = 0;
            // Kiểm tra nếu các ô nhập khác rỗng
            if (txtTen.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                //Nhận giá trị Name, Unit, và Notes từ người dùng nhập vào
                job.NameJob = txtTen.Text;

                //Thêm thời gian bắt đầu
                job.ToDate = new DateTime(
                 dtpNgayBD.Value.Year,
                 dtpNgayBD.Value.Month,
                 dtpNgayBD.Value.Day,
                 (int)nupGioBD.Value,  // Ép trực tiếp giá trị decimal thành int
                 (int)nupPhutBD.Value, // Tương tự
                 0                     // Giây
                );

                //Thêm thời gian kết thúc
                job.FromDate = new DateTime(
                 dtpNgayBD.Value.Year,
                 dtpNgayBD.Value.Month,
                 dtpNgayBD.Value.Day,
                 (int)nupGioBD.Value,  // Ép trực tiếp giá trị decimal thành int
                 (int)nupPhutBD.Value, // Tương tự
                 0                     // Giây
                );

                // Nếu thời gian bắt đầu lớn hơn hoặc bằng thời gian kết thúc
                if (job.FromDate >= job.ToDate)
                {
                    // Điều chỉnh lại thời gian bắt đầu: cộng thêm 5 phút vào thời gian kết thúc
                    job.FromDate = job.ToDate.AddMinutes(5);
                }

                //Trang thái
                if (chbJob.Checked)
                    job.Status = 1; // Đã hoàn thành
                else job.Status = 0; // Chưa check

                job.Category = txtTheLoai.Text;

                if (cmbMucDo.SelectedIndex == -1) // Auto chon Item 0
                    cmbMucDo.SelectedIndex = 0;
                if (cmbMucDo.SelectedIndex == 0)
                    job.LevelJob = 0;
                else job.LevelJob = 1;

                job.Notes = txtNotes.Text;

                JobBL jobBL = new JobBL();
                // Chèn dữ liệu vào bảng
                return jobBL.Insert(job);
            }
            return -1;
        }

        public void InsertJobChild(int Job)
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
                    jobChild.JobID = Job;
                    JobChildBL jobChildBL = new JobChildBL();
                    jobChildBL.Insert(jobChild);
                }

            }

        }

        void UpdateJobToSql()
        {

        }

    }
}

