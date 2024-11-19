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


namespace FormPhu
{
    public partial class ThongBao : Form
    {
        List<Job> jobs = new List<Job>();
        public ThongBao(JobDA dscv)
        {
            InitializeComponent();
            jobs = dscv.DanhSach;
            
        }

        int i = 0;
        int gio = 1;
        private void iconNoti_Click(object sender, EventArgs e)
        {

        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            foreach (Job job in jobs)
            {
                //if (job.ToDate.AddHours(gio) == DateTime.Now)
                //{
                ThongBaoCon thongBaoCon = new ThongBaoCon(job);
                flowLayoutPanel1.Controls.Add(thongBaoCon);
                flowLayoutPanel1.Controls.SetChildIndex(thongBaoCon, 0);
                //}        
            }
        }


       
    }
}
