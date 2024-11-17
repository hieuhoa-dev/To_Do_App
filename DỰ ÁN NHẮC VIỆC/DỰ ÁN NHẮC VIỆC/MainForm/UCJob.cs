using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class UCJob : UserControl
    {
        private Job jobItem;
        
        public Job JobItem
        {
            get { return jobItem; }
            set { jobItem = value; }
        } 

        public UCJob(Job jobItem)
        {
            InitializeComponent();

            this.JobItem = jobItem;
            ShowInfo();
        }
        public UCJob()
        {
            InitializeComponent();
        }

        void ShowInfo()
        {
            btnInfo.Text = JobItem.NameJob;
            //Them thuoc tinh ...
        }
       

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        private void ctmsSua_Click(object sender, EventArgs e)
        {
            JobItem.NameJob = btnInfo.Text;
            //Them thuoc tinh ...
            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void ctmsXoa_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }

        public delegate void JobClickEventHandler(object sender, EventArgs e, DataAccess.Job cv);
        public event JobClickEventHandler JobClicked;
        
        private void btnInfo_Click(object sender, EventArgs e)
        {
            DataAccess.Job cv = this.JobItem;
            JobClicked?.Invoke(sender, e, cv);
        }

    
    } 
}
