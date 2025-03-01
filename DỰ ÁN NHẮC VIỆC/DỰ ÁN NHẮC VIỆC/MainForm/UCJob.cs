﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
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
            if (jobItem.Delete == 0)
            {
                this.btnInfo.ContextMenuStrip = this.ctnsDelete;
            }
            else
            {
                this.btnInfo.ContextMenuStrip = this.ctnsHavedDelete;
            }
            ShowInfo();
        }


        void ShowInfo()
        {
            btnInfo.Text = JobItem.NameJob;
            if (JobItem.Status == 1)
                cbJob.Checked = true;
            else cbJob.Checked = false;
            LoadMucDo();
        }

        int BienLuuMucDo;
        void LoadMucDo()
        {
            if (jobItem.LevelJob == 1)
            {
                iconFlat.IconColor = Color.FromArgb(174, 68, 90);
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                iconFlat.IconColor = Color.Black;
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            }
            BienLuuMucDo = jobItem.LevelJob;
        }
        private void ctmsXoa_Click(object sender, EventArgs e)
        {
            JobItem.Delete = 1;
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
            JobListLoad?.Invoke(sender, e);
        }
        private void khôiPhụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobItem.Delete = 0;
            JobBL jobBL = new JobBL();
            jobBL.Update(jobItem);
            JobListLoad?.Invoke(sender, e);
        }

        private void xóaVĩnhViễnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá công việc này?", "Thông báo",

             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                JobBL jobBL = new JobBL();
                jobBL.Delete(jobItem);
                JobListLoad?.Invoke(sender, e);
            }
        }

        public event EventHandler JobListLoad;

        public delegate void JobClickEventHandler(object sender, EventArgs e, DataAccess.Job cv);
        public event JobClickEventHandler JobClicked;

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DataAccess.Job cv = this.JobItem;
            JobClicked?.Invoke(sender, e, cv);
        }

        private void iconFlat_Click(object sender, EventArgs e)
        {
            if (BienLuuMucDo == 0)
            {
                iconFlat.IconColor = Color.FromArgb(174, 68, 90);
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Solid;
                jobItem.LevelJob = 1;
                BienLuuMucDo = 1;
            }
            else
            {
                iconFlat.IconColor = Color.Black;
                iconFlat.IconFont = FontAwesome.Sharp.IconFont.Auto;
                jobItem.LevelJob = 0;
                BienLuuMucDo = 0;
            }
            CapNhatThongTin(sender, e);
        }

        private void cbJob_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJob.Checked)
            {
                jobItem.Status = 1;
            }
            else jobItem.Status = 0;
            CapNhatThongTin(sender, e);
        }
        void CapNhatThongTin(object sender, EventArgs e)
        {
            JobBL jobBL = new JobBL();
            // Cập nhật dữ liệu trong bảng
            jobBL.Update(jobItem);
            DataAccess.Job cv = this.JobItem;
            JobClicked?.Invoke(this, e, cv);
        }


    }
}
