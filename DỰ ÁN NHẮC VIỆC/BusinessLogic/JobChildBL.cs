using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // Lớp FoodBL có các phương thức xử lý bảng Food
    public class JobChildBL
    {
        //Đối tượng CategoryDA từ DataAccess
        JobChildDA jobChildDA = new JobChildDA();
        //Phương thức lấy hết dữ liệu
        public List<JobChild> GetAll()
        {
            return jobChildDA.GetAll();
        }

        //Phương thức thêm dữ liệu
        public int Insert(JobChild jobChild)
        {
            return jobChildDA.Insert_Update_Delete(jobChild, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(JobChild jobChild)
        {
            return jobChildDA.Insert_Update_Delete(jobChild, 1);
        }
        //Phương thức xoá dữ liệu với ID cho trước
        public int Delete(JobChild jobChild)
        {
            return jobChildDA.Insert_Update_Delete(jobChild, 2);
        }

        // Tìm kiếm theo
        public List<JobChild> FindID(int JobID)
        {
            List<JobChild> list = GetAll(); 
            List<JobChild> result = new List<JobChild>();
            // Duyệt theo danh sách
            foreach (var item in list)
            {
                // Nếu từng trường chứa từ khoá
                if (JobID == item.JobID)
                    result.Add(item); // Thì thêm vào danh sách kết quả
            }
            return result;
        }
    }
}
