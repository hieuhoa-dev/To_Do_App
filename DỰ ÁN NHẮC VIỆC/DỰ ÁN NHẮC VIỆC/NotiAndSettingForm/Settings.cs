using DỰ_ÁN_NHẮC_VIỆC.NotiAndSettingForm;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace FormPhu
{
    public partial class Settings : Form
    {
        public bool TrangThaiThongBao = false;
        
        public Settings()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            // Gán các giá trị cho ComboBox
            cbbHienThiTB.Items.AddRange(new string[] { "Cho phép", "Không" });
            cbbHienThiTB.SelectedIndex = SettingsState.IsToastEnabled ? 0 : 1;
            TrangThaiThongBao = SettingsState.IsToastEnabled;
            // Đảm bảo sự kiện SelectedIndexChanged được đăng ký đúng
            cbbHienThiTB.SelectedIndexChanged += cbbHienThiTB_SelectedIndexChanged;
        }

        public EventHandler LoadJob;
        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            frmDuLieu dl = new frmDuLieu();
            dl.LoadJob += LoadJob;
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
        public event EventHandler TrangThaiNoti;
        private void cbbHienThiTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu SelectedIndex thay đổi
            if (cbbHienThiTB.SelectedIndex == 0 && SettingsState.IsToastEnabled == false)
            {
                // Chọn "Có" và chưa bật thông báo
                SettingsState.IsToastEnabled = true;
                MessageBox.Show("Thông báo đã được thay đổi thành trạng thái bật");
                TrangThaiNoti.Invoke(this, e);
            }
            else if (cbbHienThiTB.SelectedIndex == 1 && SettingsState.IsToastEnabled == true)
            {
                // Chọn "Không" và thông báo đang bật
                SettingsState.IsToastEnabled = false;
                MessageBox.Show("Thông báo đã được thay đổi thành trạng thái tắt");
                TrangThaiNoti.Invoke(this, e);
            }

        }
    }
}
