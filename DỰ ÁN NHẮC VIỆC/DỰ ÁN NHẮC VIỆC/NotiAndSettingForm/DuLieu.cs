using BusinessLogic;
using DataAccess;
using DỰ_ÁN_NHẮC_VIỆC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private JobBL jobBL;
        private ListForm listForm;
        public frmDuLieu()
        {
            InitializeComponent();
            //jobService = new JobService();
            //listForm = new ListForm(); // Khởi tạo Form hiển thị danh sách công việc
            //listForm.Show(); // Hiển thị Form ListForm

        }

        public event EventHandler LoadJob;
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                var jobList = ReadCsvFile(filePath); // Lấy danh sách công việc từ BLL
                JobBL jobBL = new JobBL();
                foreach (var item in jobList)
                {
                    jobBL.Insert(item);
                }
                MessageBox.Show("Nhập file thành công");
                LoadJob.Invoke(this,e);
            }
        }


        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Lấy trạng thái hoàn thành từ checkbox
                bool? daHoanThanh = chkDaHoanThanh.Checked ? true :
                                     chkChuaHoanThanh.Checked ? false : (bool?)null;
                JobBL jobBL = new JobBL();

                List<Job> jobList = jobBL.GetAll();

                // Gọi phương thức ExportToCsv từ tầng Business Logic Layer
                ExportToCsv(jobList, filePath, daHoanThanh);

                MessageBox.Show("Xuất file thành công!", "Thông báo");

                txtDuongDan.Text = filePath; // Hiển thị đường dẫn file xuất
            }
        }
        private void frmDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        // Phương thức đọc file CSV và trả về DataTable (hoặc List<Job>)
        public List<Job> ReadCsvFile(string filePath)
        {
            List<Job> jobList = new List<Job>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] headers = reader.ReadLine()?.Split(',');
                if (headers != null)
                {
                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine()?.Split(',');
                        if (rows != null && rows.Length == headers.Length)
                        {
                            Job job = new Job();
                            job.ID = 0;
                            job.NameJob = rows[0];
                            job.ToDate = DateTime.ParseExact(rows[1], "MM/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                            job.FromDate = DateTime.ParseExact(rows[2], "MM/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                            if (rows[3] == "Đã hoàn thành")
                            {
                                job.Status = 1;

                            }
                            else
                            {
                                job.Status = 0;
                            }
                            job.Category = rows[4];
                            if (rows[5] == "Quan trọng")
                            {
                                job.LevelJob = 1;

                            }
                            else
                            {
                                job.LevelJob = 0;
                            }


                            job.Notes = rows[6];
                            job.TimeDelete = DateTime.Now;

                            jobList.Add(job);
                        }
                    }
                }
            }

            return jobList;
        }
        // Xuất danh sách công việc ra file CSV
        public void ExportToCsv(List<Job> jobList, string filePath, bool? daHoanThanh)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("Tên công việc,Ngày bắt đầu,Ngày kết thúc,Trạng thái,Thể loại,Mức độ,Ghi chú");

                foreach (var job in jobList)
                {
                    if (daHoanThanh.HasValue && job.Status != (daHoanThanh.Value ? 1 : 0))
                    {
                        continue;
                    }
                    string status = job.Status == 1 ? "Đã hoàn thành" : "Chưa hoàn thành";
                    string leveljob = job.LevelJob == 1 ? "Quan trọng" : "Bình thường";
                    writer.WriteLine($"{job.NameJob},{job.ToDate},{job.FromDate},{status},{job.Category},{leveljob},{job.Notes}");
                }
            }
        }
    }
}
