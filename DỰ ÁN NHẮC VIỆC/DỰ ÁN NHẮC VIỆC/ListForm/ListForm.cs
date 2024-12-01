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

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class ListForm : Form
    {
       List<Job> jobList = new List<Job>();

        static string constr = ConfigurationManager.ConnectionStrings["QuanLyCongViec"].ConnectionString;
        public DataGridView DataGridView => dgvDanhSachCongViec;
        public void SetDataSource(DataTable dataTable)
        {
            dgvDanhSachCongViec.DataSource = dataTable;
            dgvDanhSachCongViec.Refresh();
        }


        public ListForm()
        {
            InitializeComponent();
        }

        private void dgvDanhSachCongViec_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dòng hiện tại
            DataGridViewRow row = dgvDanhSachCongViec.Rows[e.RowIndex];

            // Lấy giá trị các cột
            string nameJob = row.Cells["NameJob"].Value.ToString();
            DateTime fromDate = Convert.ToDateTime(row.Cells["FromDate"].Value);
            DateTime toDate = Convert.ToDateTime(row.Cells["ToDate"].Value);
            int status = row.Cells["Status"].Value.ToString() == "Đã hoàn thành" ? 1 : 0;

            // Cập nhật vào cơ sở dữ liệu
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                string query = "UPDATE JOB SET FromDate = @FromDate, ToDate = @ToDate, Status = @Status WHERE NameJob = @NameJob";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@NameJob", nameJob);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable LayDanhSach(string column = null, string value = null, bool? daHoanThanh = null)
        {
            // Câu truy vấn mặc định
            string query = "SELECT NameJob, ToDate, FromDate, Status, Category, LevelJob, Notes FROM JOB";

            // Điều kiện lọc theo tên cột
            if (!string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(value))
            {
                query += $" WHERE {column} LIKE @value";
            }

            // Lọc theo trạng thái (Đã hoàn thành/Chưa hoàn thành)
            if (daHoanThanh.HasValue)
            {
                query += (query.Contains("WHERE") ? " AND " : " WHERE ") + "Status = @status";
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);

                // Thêm tham số tìm kiếm cho tên công việc
                if (!string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(value))
                {
                    cmd.Parameters.AddWithValue("@value", $"%{value}%");
                }

                // Thêm tham số trạng thái (0 hoặc 1)
                if (daHoanThanh.HasValue)
                {
                    cmd.Parameters.AddWithValue("@status", daHoanThanh.Value ? 1 : 0);
                }

                SqlDataReader da = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(da);
                return dt;
            }

        }


        private void ListForm_Load(object sender, EventArgs e)
        {
            //C1
            dgvDanhSachCongViec.DefaultCellStyle.ForeColor = Color.Black;
            //dgvDanhSachCongViec.DataSource = LayDanhSach();
            //C2
            JobBL jobBL = new JobBL();
            jobList = jobBL.GetAll();
            dgvDanhSachCongViec.DataSource = jobList;



            cbbTimKiem.Text = "Tên công việc";
            dgvDanhSachCongViec.CellFormatting += DgvDanhSachCongViec_CellFormatting;
            dgvDanhSachCongViec.CellValueChanged += dgvDanhSachCongViec_CellValueChanged;
        }
        private void DgvDanhSachCongViec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDanhSachCongViec.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                e.Value = e.Value.ToString() == "1" ? "Đã hoàn thành" : "Chưa hoàn thành";
                e.FormattingApplied = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                return;
            }

            string column = null;
            bool? daHoanThanh = null;

            // Xử lý điều kiện tìm kiếm theo cột
            switch (cbbTimKiem.Text)
            {
                case "Mức độ":
                    column = "LevelJob";
                    break;
                case "Tên công việc":
                    column = "NameJob";
                    break;
                case "Thể loại":
                    column = "Category";
                    break;
                default:
                    return;
            }
            // Lọc dữ liệu
            dgvDanhSachCongViec.DataSource = LayDanhSach(column, txtTimKiem.Text.Trim(), daHoanThanh);
        }
    }
}
