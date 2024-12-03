using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLogic;
using DataAccess;
using System.Linq;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class ListForm : Form
    {
        private JobBL jobBL = new JobBL();
        private List<Job> jobList;
        public ListForm()
        {
            InitializeComponent();
        }
        public void SetDataSource(List<Job> jobs)
        {
            dgvDanhSachCongViec.DataSource = jobs;
            dgvDanhSachCongViec.Refresh();
        }
        private void ListForm_Load(object sender, EventArgs e)
        {
            // Thiết lập hiển thị DataGridView
            //dgvDanhSachCongViec.DefaultCellStyle.ForeColor = Color.Black;

            // Lấy danh sách công việc từ BusinessLogic
            jobList = jobBL.GetAll();
            foreach (Job job in jobList)
            {
                // Thêm hàng mới
                int index = dgvDanhSachCongViec.Rows.Add();

                // Gán giá trị cho các ô trong hàng
                dgvDanhSachCongViec.Rows[index].Cells["NameJob"].Value = job.NameJob;
                dgvDanhSachCongViec.Rows[index].Cells["ToDate"].Value = job.ToDate;
                dgvDanhSachCongViec.Rows[index].Cells["FromDate"].Value = job.FromDate;
                dgvDanhSachCongViec.Rows[index].Cells["Status"].Value = job.Status;
                dgvDanhSachCongViec.Rows[index].Cells["Category"].Value = job.Category;
                dgvDanhSachCongViec.Rows[index].Cells["LevelJob"].Value = job.LevelJob;
                dgvDanhSachCongViec.Rows[index].Cells["Notes"].Value = job.Notes;
            }
            //dgvDanhSachCongViec.DataSource = jobList;

            // Cài đặt sự kiện
            dgvDanhSachCongViec.CellFormatting += DgvDanhSachCongViec_CellFormatting;
            cbbTimKiem.Text = "Tên công việc";
        }
        private void DgvDanhSachCongViec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format cột trạng thái
            if (dgvDanhSachCongViec.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                e.Value = e.Value.ToString() == "1" ? "Đã hoàn thành" : "Chưa hoàn thành";
                e.FormattingApplied = true;
            }
            if (dgvDanhSachCongViec.Columns[e.ColumnIndex].Name == "LevelJob" && e.Value != null)
            {
                e.Value = e.Value.ToString() == "1" ? "Quan trọng" : "Bình thường";
                e.FormattingApplied = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                dgvDanhSachCongViec.DataSource = jobList;
                return;
                
            }
            List<Job> listkq = new List<Job>();
            //if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
            //    return;
            //}
            string column = null;
            // Dùng cấu trúc if-else thay vì switch
            if (cbbTimKiem.Text == "Tên công việc")
            {
                column = "NameJob";
            }
            if (cbbTimKiem.Text == "Trạng thái")
            {
                column = "Status";
            }
            else if (cbbTimKiem.Text == "Thể loại")
            {
                column = "Category";
            }
            else if (cbbTimKiem.Text == "Mức độ")
            {
                column = "LevelJob";
            }

            if (column != null)
            {
                listkq = jobList;
                // Lọc danh sách công việc
                listkq = jobBL.GetAll().Where(job =>
                    job.GetType().GetProperty(column)?.GetValue(job, null)?.ToString().Contains(txtTimKiem.Text) ?? false).ToList();
                dgvDanhSachCongViec.DataSource = listkq;
            }
        }
    }
}
