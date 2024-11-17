using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // Lớp CategoryBL có các phương thức xử lý bảng Category
    public class JobBL
    {
        //Đối tượng CategoryDA từ DataAccess
        JobDA jobDA = new JobDA();
        //Phương thức lấy hết dữ liệu
        public List<Job> GetAll()
        {
            return jobDA.GetAll();
        }
        //Phương thức thêm dữ liệu
        public int Insert(Job job)
        {
            return jobDA.Insert_Update_Delete(job, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(Job job)
        {
            return jobDA.Insert_Update_Delete(job, 1);
        }
        //Phương thức xoá dữ liệu truyền vào ID
        public int Delete(Job job)
        {
            return jobDA.Insert_Update_Delete(job, 2);
        }
    }
}
