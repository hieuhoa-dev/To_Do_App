using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class ThongBaoCon : UserControl
    {
        Notify Notify = new Notify();
        public event EventHandler Noitify_Load;
        public ThongBaoCon(Notify notify)
        {
            InitializeComponent();
            this.Notify = notify;
            lbLoaiTB.Text = notify.Category;
            this.toolTip1.SetToolTip(this.lbTenCV, notify.NameJob);
            if (notify.NameJob.Length > 10)
            {
                lbTenCV.Text = notify.NameJob.Substring(0, 10) + "..."; // Lấy 10 ký tự đầu tiên
            }
            else
            {
                lbTenCV.Text = notify.NameJob;
            }

        }

        private void iconXmark_Click(object sender, EventArgs e)
        {
            NotifyBL notifyBL = new NotifyBL();
            notifyBL.Delete(Notify);
            Noitify_Load?.Invoke(this,e);
        }
    }
}
