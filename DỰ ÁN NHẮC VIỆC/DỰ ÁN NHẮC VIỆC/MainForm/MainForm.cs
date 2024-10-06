using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;

using ListForm;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class MainForm : Form
    {
        DSCongViec dscv = new DSCongViec();
        Panel pnlDeskTops = new Panel();
        public Panel pnlJobChild = new Panel();
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

        private DSCongViec _dsCongViec;
        private DSCongViec DsCongViec
        {
            get { return _dsCongViec; }
            set { _dsCongViec = value; }

        }

        public MainForm()
        {
            InitializeComponent();
            m_aeroEnabled = false;
            TaopnlDeskTops();

            


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
        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconCalendar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CalendarForm(), sender);
        }

        private void iconList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListForm(), sender);
        }

        private void iconSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }



        #endregion




        private void mCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            pnlShowJob.Controls.Clear();
            JobList jobList = new JobList(new DateTime(mCalendar.SelectionStart.Year, mCalendar.SelectionStart.Month, mCalendar.SelectionStart.Day), dscv);
            pnlShowJob.Controls.Add(jobList);
            
        }

        public MonthCalendar mouthCalendar
        {
            get { return mCalendar; }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            iconHome.IconColor = Color.FromArgb(17, 103, 177);
            dscv.DocTuFile(Application.StartupPath + "/CongViec.txt");
            Job job = new Job(this);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            JobList jobList = new JobList(new DateTime(mCalendar.SelectionStart.Year, mCalendar.SelectionStart.Month, mCalendar.SelectionStart.Day), dscv);
            jobList.ThemJob();
        }


        private void iconDonate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconNoti_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);
        }

       
    
        void TaopnlDeskTops()
        {
            pnlDeskTops.Location = new System.Drawing.Point(80, 46);
            pnlDeskTops.Size = new System.Drawing.Size(1320, 916);
            pnlDeskTops.TabIndex = 25;
            pnlDeskTops.BringToFront();
            this.Controls.Add(pnlDeskTops);  
        }

        private void iconSearch_Click(object sender, EventArgs e)
        {

        }

    }
}
