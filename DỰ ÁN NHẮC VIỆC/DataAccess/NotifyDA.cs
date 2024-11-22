using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NotifyDA
    {
        // Phương thức lấy hết dữ liệu theo thủ tục Food_GetAll
        public List<Notify> GetAll()
        {
            //Khai báo đối tượng SqlConnection và mở kết nối
            //Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Notify_GetAll;
            // Đọc dữ liệu, trả về danh sách các đối tượng Food
            SqlDataReader reader = command.ExecuteReader();
            List<Notify> list = new List<Notify>();
            while (reader.Read())
            {
                Notify notify = new Notify();
                notify.ID = Convert.ToInt32(reader["ID"]);
                notify.Category = reader["Category"].ToString();
                notify.NameJob = reader["NameJob"].ToString();
                list.Add(notify);
            }
            // Đóng kết nối và trả về danh sách
            sqlConn.Close();
            return list;
        }
        // Phương thức thêm, xoá, sửa theo thủ tục Food_InsertUpdateDelete
        public int Insert_Update_Delete(Notify notify, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Notify_InsertUpdateDelete;

            // Thêm các tham số cho thủ tục; Các tham số này chính là các  tham số trong thủ tục;
            //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xoá,  sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = notify.ID;

            //Các biến còn lại chỉ truyền vào
            command.Parameters.Add("@Category", SqlDbType.NVarChar, 200).Value = notify.Category;
            command.Parameters.Add("@NameJob", SqlDbType.NVarChar, 200).Value = notify.NameJob;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;
            int result = command.ExecuteNonQuery();
            // Thực thi lệnh
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
    }
}
