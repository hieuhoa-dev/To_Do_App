using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobDA
    {
        public List<Job> DanhSach;

        public JobDA()
        {
            DanhSach = new List<Job>();
        }

        public Job this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }


        public List<Job> GetAll()
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Job_GetAll;

            // Đọc dữ liệu, trả về danh sách các đối tượng Category
            SqlDataReader reader = command.ExecuteReader();
            List<Job> list = new List<Job>();
            while (reader.Read())
            {
                Job job = new Job();
                job.ID = Convert.ToInt32(reader["ID"]);
                job.NameJob = reader["NameJob"].ToString();
                job.ToDate = (DateTime)reader["ToDate"];
                job.FromDate = (DateTime)reader["FromDate"];
                job.Status = Convert.ToInt32(reader["Status"]);
                job.Category = reader["Category"].ToString();
                job.LevelJob = Convert.ToInt32(reader["LevelJob"]);
                job.Notes = reader["Notes"].ToString();
                list.Add(job);
            }
            // Đóng kết nối và trả về danh sách
            sqlConn.Close();
            return list;
        }

        //Phương thức thêm, xoá, sửa theo thủ tục Category_InsertUpdateDelete
        public int Insert_Update_Delete(Job job, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Job_InsertUpdateDelete;
            // Thêm các tham số cho thủ tục; Các tham số này chính là các  tham số trong thủ tục;

            //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xoá, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput; // Vừa vào vừa ra
            command.Parameters.Add(IDPara).Value = job.ID;
            command.Parameters.Add("@NameJob", SqlDbType.NVarChar, 200).Value = job.NameJob;
            command.Parameters.Add("@ToDate", SqlDbType.DateTime).Value =  job.ToDate;
            command.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = job.FromDate;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = job.Status;
            command.Parameters.Add("@Category", SqlDbType.NVarChar, 100).Value = job.Category;
            command.Parameters.Add("@LevelJob", SqlDbType.Int).Value = job.LevelJob;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 1000).Value = job.Notes;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            // Thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }





    }
}
