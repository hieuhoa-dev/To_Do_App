using DỰ_ÁN_NHẮC_VIỆC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormPhu
{
    public partial class frmDuLieu : Form
    {
        private ListForm listForm;
        private MainForm mainForm;
        public frmDuLieu()
        {
            InitializeComponent();
            listForm = new ListForm();
            listForm.Show();


        }


        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable dataTable = ReadCsvFile(filePath);

                if (dataTable.Rows.Count > 0)
                {
                    // Cập nhật dữ liệu vào ListForm
                    listForm.SetDataSource(dataTable);
                }
                else
                {
                    MessageBox.Show("File CSV không có dữ liệu hoặc không hợp lệ!", "Lỗi");
                }
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Lấy giá trị trạng thái từ checkbox
                bool? daHoanThanh = null;

                if (chkDaHoanThanh.Checked)
                {
                    daHoanThanh = true; // Đã hoàn thành
                }
                else if (chkChuaHoanThanh.Checked)
                {
                    daHoanThanh = false; // Chưa hoàn thành
                }

                // Xuất DataGridView với điều kiện lọc trạng thái
                ExportToCsv(listForm.DataGridView, filePath, daHoanThanh);
                MessageBox.Show("Xuất file thành công!", "Thông báo");

                // Hiển thị đường dẫn lên TextBox
                txtDuongDan.Text = filePath;
            }
        }

        // Đọc file CSV
        private DataTable ReadCsvFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (StreamReader reader = new StreamReader(filePath))
            {
                // Đọc tiêu đề cột
                string[] headers = reader.ReadLine()?.Split(',');
                if (headers != null)
                {
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header.Trim());
                    }

                    // Đọc dữ liệu từng dòng
                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine()?.Split(',');
                        if (rows != null && rows.Length == headers.Length) // Đảm bảo số cột khớp
                        {
                            dataTable.Rows.Add(rows);
                        }
                    }
                }
            }
            return dataTable;
        }

        // Xuất DataGridView ra file CSV, có điều kiện lọc theo trạng thái
        private void ExportToCsv(DataGridView dataGridView, string filePath, bool? daHoanThanh)
{
    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8)) // Chỉ định UTF-8
    {
        // Xuất tiêu đề cột
        string[] columnNames = dataGridView.Columns
            .Cast<DataGridViewColumn>()
            .Select(column => column.HeaderText)
            .ToArray();
        writer.WriteLine(string.Join(",", columnNames));

        // Xuất dữ liệu từng dòng, có điều kiện lọc theo trạng thái
        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            if (!row.IsNewRow)
            {
                // Kiểm tra trạng thái lọc, chỉ xuất dòng có trạng thái phù hợp
                if (daHoanThanh.HasValue)
                {
                    int status = Convert.ToInt32(row.Cells["Status"].Value);
                    if (status != (daHoanThanh.Value ? 1 : 0))
                    {
                        continue; // Bỏ qua nếu trạng thái không khớp
                    }
                }

                // Thay đổi giá trị cột Status khi ghi ra file
                string[] cells = row.Cells
                    .Cast<DataGridViewCell>()
                    .Select(cell =>
                    {
                        if (cell.OwningColumn.Name == "Status")
                        {
                            return cell.Value?.ToString() == "1" ? "Đã hoàn thành" : "Chưa hoàn thành";
                        }
                        return cell.Value?.ToString() ?? "";
                    })
                    .ToArray();

                writer.WriteLine(string.Join(",", cells));
            }
        }
    }
}

        private void frmDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            listForm.SetDataSource(listForm.LayDanhSach());
        }
    }
}
