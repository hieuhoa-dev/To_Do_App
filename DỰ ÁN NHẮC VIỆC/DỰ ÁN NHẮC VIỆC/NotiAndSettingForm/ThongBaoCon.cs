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

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class ThongBaoCon : UserControl
    {

        public ThongBaoCon(Job job)
        {
            InitializeComponent();
            lbLoaiTB.Text = "Sắp đến";
            lbTenCV.Text = job.NameJob;
        }

    }
}
