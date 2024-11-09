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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            frmDuLieu dl = new frmDuLieu();
            dl.MdiParent = this;
            dl.Dock = DockStyle.Fill;
            dl.StartPosition = FormStartPosition.Manual;
            dl.Show();
            
        }
        void HideAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Hide();
            }
        }
        private void btnThongBao_Click(object sender, EventArgs e)
        {
           
            HideAllChildForms();
            panel2.Visible = true;
        }
    }
}
