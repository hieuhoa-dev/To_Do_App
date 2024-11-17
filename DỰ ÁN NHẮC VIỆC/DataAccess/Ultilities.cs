using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class Ultilities
    {
        // lấy chuỗi kết nối từ tập tin App.Config
        private static string StrName = "QuanLyCongViec";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

        // Các biến của bảng Job
        public static string Job_GetAll = "Job_GetAll";
        public static string Job_InsertUpdateDelete = "Job_InsertUpdateDelete";

        // Các biến của bảng JobChild
        public static string JobChild_GetAll = "JobChild_GetAll";
        public static string JobChild_InsertUpdateDelete = "JobChild_InsertUpdateDelete";


    }
}
