using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

using FormPhu;
using Other;
using DataAccess;
using BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Linq;
using Microsoft.Win32;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class MainForm : Form
    {
        JobDA dscv = new JobDA();
        Panel pnlDeskTops = new Panel();
        public Panel pnlJobChild = new Panel();
        List<Job> DScv = new List<Job>();
        //Tạo khung, viền, bóng
        #region DesignFrom 
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        #endregion

        public MainForm()
        {

            InitializeComponent();
            // m_aeroEnabled = false;
            TaopnlDeskTops();
            //KhoiDongCungVoiWindow();
            tmNotify.Enabled = TrangThaiThongBao;
        }
        //Tạo thoát, thu nhỏ
        #region 
        private void iconXmark_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconQuare_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }
        #endregion

        // Chức năng nút Today
        #region

        #endregion

        //cài đặt màu cho nút Control, mở file tương ứng
        #region btnControl
        IconButton currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(17, 103, 177);
                    currentButton = (IconButton)btnSender;
                    currentButton.IconColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlControl2.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    if (previousBtn is IconButton previousBtnControl)
                    {
                        previousBtnControl.IconColor = Color.DarkGray;
                    }
                }
            }
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            lbSeparator1.Visible = false;
            lbSeparator2.Visible = false;
            pnlDeskTops.Visible = true;
            //if (activeForm != null)
            //    activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDeskTops.Controls.Add(childForm);
            this.pnlDeskTops.Tag = childForm;
            childForm.BringToFront();
            pnlDeskTops.BringToFront();
            childForm.Show();

        }


        private void iconHome_Click(object sender, EventArgs e)
        {
            lbSeparator1.Visible = true;
            lbSeparator2.Visible = true;
            pnlDeskTops.Visible = false;
            ActivateButton(sender);
        }
    

        private void iconCalendar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Calendarform.CalendarForm(dscv), sender);
        }

        private void iconList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListForm(), sender);
        }
        bool TrangThaiThongBao = false;
        private void iconSetting_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.LoadJob += LoadJob;
            TrangThaiThongBao = settings.TrangThaiThongBao;
            settings.TrangThaiNoti += SetThongBao;
            settings.Show();
        }
        private void SetThongBao(object sender, EventArgs e)
        {
            tmNotify.Enabled = TrangThaiThongBao;
        }



        #endregion


        private void mCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowJobbyDay(new DateTime(mCalendar.SelectionStart.Year, mCalendar.SelectionStart.Month, mCalendar.SelectionStart.Day), dscv);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            iconHome.IconColor = Color.FromArgb(17, 103, 177);
            LoadJobToSQL();
            ShowJobbyDay(DateTime.Now, dscv);
        }
        private void LoadJobToSQL()
        {
            //Gọi đối tượng CategoryBL từ tầng BusinessLogic
            JobBL jobBL = new JobBL();
            DScv = jobBL.GetAll();
            dscv.DanhSach = DScv;
        }


        void ShowJobbyDay(DateTime time, JobDA dscv)
        {
            LoadHienThiThongTin(time);
            pnlShowJob.Controls.Clear();
            UCJobList jobList = new UCJobList(new DateTime(time.Year, time.Month, time.Day), dscv);
            pnlShowJob.Controls.Add(jobList);
            jobList.ListJobClick += Job_JobClicked;
            //jobList.JobChildLoad += JobChildLoad;
        }

        public EventHandler JobChildLoad;

        void EventJobChildLoad(object sender, EventArgs e)
        {
            JobChildLoad?.Invoke(this, e);
        }
        void SetDefautDate()
        {
            mCalendar.SelectionEnd = DateTime.Now;
            mCalendar.SelectionStart = DateTime.Now;
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefautDate();


        }

        void LoadHienThiThongTin(DateTime time)
        {
            DateTime now = DateTime.Now.Date; // Lấy phần ngày hiện tại, bỏ giờ phút giây
            int diff = (time.Date - now).Days; // Tính số ngày chênh lệch

            if (diff == 0)
            {
                lbHienThiThongTin.Text = $"Hôm nay, {time:dd/MM/yyyy}";
                return;
            }
            if (diff == 1)
            {
                lbHienThiThongTin.Text = $"Ngày mai, {time:dd/MM/yyyy}";
                return;
            }
            if (diff == -1)
            {
                lbHienThiThongTin.Text = $"Hôm qua, {time:dd/MM/yyyy}";
                return;
            }
            else
            {
                lbHienThiThongTin.Text = time.ToString("dd/MM/yyyy");
            }
        }

        ThongBao NotiForm = new ThongBao();

        private void iconDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://me.momo.vn/N6IpTpsOu3U4IgtnCbtaU8/olejYMpwQYABdjN",
                UseShellExecute = true // Đảm bảo sử dụng trình duyệt mặc định
            });
        }

        Panel pnlNoti = null;
        private void iconNoti_Click(object sender, EventArgs e)
        {

            if (pnlNoti != null)
            {
                this.Controls.Remove(pnlNoti);
                pnlNoti.Dispose(); // Giải phóng tài nguyên nếu cần
                pnlNoti = null; // Xóa tham chiếu đến Panel
            }
            else
            {
                // Tạo mới Panel và thêm vào form
                pnlNoti = new Panel();
                pnlNoti.Location = new System.Drawing.Point(1061, 46);
                pnlNoti.Size = new System.Drawing.Size(221, 250);
                this.Controls.Add(pnlNoti);
                NotiForm = new ThongBao();
                NotiForm.TopLevel = false;
                pnlNoti.Controls.Add(NotiForm);
                pnlNoti.BringToFront();
                NotiForm.Show();
            }
        }

        void TaopnlDeskTops()
        {
            pnlDeskTops.Location = new System.Drawing.Point(80, 46);
            pnlDeskTops.Size = new System.Drawing.Size(1320, 916);
            pnlDeskTops.TabIndex = 25;
            pnlDeskTops.BringToFront();
            this.Controls.Add(pnlDeskTops);
        }


        private void Job_JobClicked(object sender, EventArgs e, Job cv)
        {
            //Tìm ds công việc con của cv
            JobChildBL jobChildBL = new JobChildBL();
            List<JobChild> cvCon = jobChildBL.FindID(cv.ID);

            UCJobChild jobChild = new UCJobChild(cv, cvCon);
            jobChild.JobLoad += LoadJob;
            pnlShowJobChild.Controls.Clear();
            pnlShowJobChild.Controls.Add(jobChild);
        }


        Panel pnlAdd = null;
        private void iconAdd_Click(object sender, EventArgs e)
        {
            Clear_pnlAdd();
            pnlAdd = new Panel();
            pnlAdd.Location = new System.Drawing.Point(890, 350);
            pnlAdd.Size = new System.Drawing.Size(500, 600);
            this.Controls.Add(pnlAdd);

            AddForm addForm = new AddForm();
            addForm.FormClosed += new FormClosedEventHandler(addForm_FormClosed);
            addForm.TopLevel = false;
            pnlAdd.Controls.Add(addForm);
            pnlAdd.BringToFront();
            addForm.Show();

            addForm.btnSaveClick += LoadJob;
        }
        void addForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clear_pnlAdd();
        }

        void Clear_pnlAdd()
        {
            if (pnlAdd != null) // Có thì mới xóa 
            {
                this.Controls.Remove(pnlAdd);
                pnlAdd.Dispose();
                pnlAdd = null;
            }
        }

        private void LoadJob(object sender, EventArgs e)
        {
            LoadJobToSQL();
            ShowJobbyDay(new DateTime(mCalendar.SelectionStart.Year, mCalendar.SelectionStart.Month, mCalendar.SelectionStart.Day), dscv);
        }

        private void btnPreDay_Click(object sender, EventArgs e)
        {
            mCalendar.SelectionStart = mCalendar.SelectionStart.AddDays(-1);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            mCalendar.SelectionStart = mCalendar.SelectionStart.AddDays(1);
        }

        private void btnThungRac_Click(object sender, EventArgs e)
        {
            lbHienThiThongTin.Text = "== ĐÃ XÓA ==";
            LoadJobToSQL();
            pnlShowJob.Controls.Clear();
            UCJobList jobList = new UCJobList(dscv, 0);
            pnlShowJob.Controls.Add(jobList);
            jobList.ListJobClick += Job_JobClicked;
        }


        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            lbHienThiThongTin.Text = "== HOÀN THÀNH ==";
            LoadJobToSQL();
            pnlShowJob.Controls.Clear();
            UCJobList jobList = new UCJobList(dscv, 1);
            pnlShowJob.Controls.Add(jobList);
            jobList.ListJobClick += Job_JobClicked;
        }


        int phut = 5;

        private void tmNotify_Tick(object sender, EventArgs e)
        {
            string Coming = "Sắp đến";
            string Doing = "Đã đến";
            string Overdue = "Săp quá hạn";

            DateTime now = DateTime.Now;

            foreach (Job job in dscv.DanhSach)
            {
                // Báo 5 phút trước khi đến CV
                DateTime notifyToTime = job.ToDate.AddMinutes(-phut);
                // Báo 5 phút trước khi đến CV
                DateTime notifyFromTime = job.FromDate.AddMinutes(-phut);

                // Kiểm tra nếu thời gian nằm trong khoảng 1 phút
                if (Math.Abs((notifyToTime - now).TotalSeconds) <= 30)
                {
                    //Thông báo sắp đến
                    notifyIcon1.ShowBalloonTip(5000, Coming, job.NameJob, ToolTipIcon.None);
                    SaveNotify(job, Coming);
                    ThongBao_Load();
                }
                else if (Math.Abs((job.ToDate - now).TotalSeconds) <= 30)
                {
                    //Thông báo đã đến
                    notifyIcon1.ShowBalloonTip(5000, Doing, job.NameJob, ToolTipIcon.None);
                    SaveNotify(job, Doing);
                    ThongBao_Load();
                }
                else if (Math.Abs((notifyFromTime - now).TotalSeconds) <= 30)
                {
                    //Thông báo quá hạn
                    notifyIcon1.ShowBalloonTip(5000, Overdue, job.NameJob, ToolTipIcon.None);
                    SaveNotify(job, Overdue);
                    ThongBao_Load();
                }
            }
        }

        void ThongBao_Load()
        {
            if (NotiForm != null)
            {
                NotiForm.LoadForm();
            }
        }


        void SaveNotify(Job job, string Category)
        {
            Notify notify = new Notify();
            notify.ID = 0;
            notify.Category = Category;
            notify.NameJob = job.NameJob;
            NotifyBL notifyBL = new NotifyBL();
            notifyBL.Insert(notify);
        }

        void KhoiDongCungVoiWindow()
        {
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\ToDoApp");
            //mở registry khởi động cùng với window
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            try
            {
                //Chèn giá trị key
                regkey.SetValue("Index", keyvalue);
                regstart.SetValue("ToDoApp", Application.StartupPath + "\\DỰ ÁN NHẮC VIỆC.exe");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
