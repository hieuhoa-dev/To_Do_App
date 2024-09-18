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
    public partial class Job : UserControl
    {

        private CongViec jobItem;

        public CongViec JobItem
        {
            get { return jobItem; }
            set { jobItem = value; }
        }


        public Job(CongViec jobItem)
        {
            InitializeComponent();

            this.JobItem = jobItem;
        }
        public Job()
        {
            InitializeComponent();
        }
    }
}
