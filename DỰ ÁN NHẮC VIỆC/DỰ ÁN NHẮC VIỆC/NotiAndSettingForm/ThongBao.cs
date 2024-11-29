using DataAccess;
using DỰ_ÁN_NHẮC_VIỆC;
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

namespace FormPhu
{
    public partial class ThongBao : Form
    {
        List<Notify> ListNotify = new List<Notify>();
        public ThongBao()
        {
            InitializeComponent();
           
        }

        private void iconNoti_Click(object sender, EventArgs e)
        {

        }

        public void LoadForm()
        {
            this.Load += ThongBao_Load;
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            NotifyBL notifyBL = new NotifyBL();
            ListNotify = notifyBL.GetAll();
            foreach (Notify notify in ListNotify)
            {
                ThongBaoCon thongBaoCon = new ThongBaoCon(notify);
                thongBaoCon.Noitify_Load += this.ThongBao_Load;
                flowLayoutPanel1.Controls.Add(thongBaoCon);
                flowLayoutPanel1.Controls.SetChildIndex(thongBaoCon, 0);
            }
        }

    }
}
