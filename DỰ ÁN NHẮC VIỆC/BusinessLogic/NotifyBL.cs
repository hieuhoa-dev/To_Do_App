using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NotifyBL
    {
        NotifyDA notifyDA = new NotifyDA();
        public List<Notify> GetAll()
        {
            return notifyDA.GetAll();
        }

        //Phương thức thêm dữ liệu
        public int Insert(Notify notify)
        {
            return notifyDA.Insert_Update_Delete(notify, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(Notify notify)
        {
            return notifyDA.Insert_Update_Delete(notify, 1);
        }
        //Phương thức xoá dữ liệu với ID cho trước
        public int Delete(Notify notify)
        {
            return notifyDA.Insert_Update_Delete(notify, 2);
        }
    }
}
