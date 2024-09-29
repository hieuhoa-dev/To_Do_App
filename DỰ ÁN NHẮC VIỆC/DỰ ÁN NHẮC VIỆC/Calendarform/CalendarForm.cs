using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace DỰ_ÁN_NHẮC_VIỆC
{
    public partial class CalendarForm : Form
    {
        public int DayOfWeek = 7;
        public int DayOfCColumn = 6;
        public int dateButtonWidth = 180;
        public int dateButtonHeight = 115;
        public int margin = 0;


        // Khởi tạo biến ma trận tạo ngày tháng
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }


        private List<string> dateOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private List<string> NgayTrongTuan = new List<string> { "Hai", "Ba", "Tu", "Năm", "Sáu", "Bảy", "Chủ Nhật" };
        public CalendarForm()
        {
            InitializeComponent();
            LoadMatrix();
            ShowDateOnTop();

        }

        void ShowDateOnTop()
        {
            tsmTime.Text = "Thứ " + HienNgayTrongTuan(dtpkDate.Value.DayOfWeek) + ", Ngày " + dtpkDate.Value.Day.ToString() + " ,Tháng " + dtpkDate.Value.Month.ToString()
                + " ,Năm " + dtpkDate.Value.Year.ToString();
        }
        string HienNgayTrongTuan(DayOfWeek dayOfWeek)
        {
            int Ngay = dateOfWeek.IndexOf(dayOfWeek.ToString());
            return NgayTrongTuan[Ngay];
        }
        void LoadMatrix()
        {

            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(margin, 0) };
            for (int i = 0; i < DayOfCColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = dateButtonWidth, Height = dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + margin, oldBtn.Location.Y);


                    btn.MouseUp += Btn_MouseClick;
                    pnlMatrix.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }

                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-margin, oldBtn.Location.Y + dateButtonHeight) };
            }

            SetDefaultDate();
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ShowJob(DateTime.Now);
            }

        }


        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        void AddNumberIntoMatrixDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());

                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                btn.ForeColor = Color.Black;
                btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.FlatAppearance.BorderColor = Color.Black;
                    btn.BackColor = Color.Bisque;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatStyle = FlatStyle.Flat;
                }

                ChangeButtonColor(btn, useDate);


                if (column >= 6)
                    line++;


                useDate = useDate.AddDays(1);

            }

        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixDate((sender as DateTimePicker).Value);
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;

        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void hômNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        void ShowJob(DateTime i)
        {
            ContextMenuStrip JobByI = new ContextMenuStrip();
            string DateTimeByI = "Thứ " + HienNgayTrongTuan(i.DayOfWeek) + ", Ngày " + i.Day.ToString() + " ,Tháng " + i.Month.ToString()
                + " ,Năm " + dtpkDate.Value.Year.ToString();
            JobByI.Items.Add(DateTimeByI);
            JobByI.Items[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            JobByI.Items[0].BackColor = Color.FromArgb(64, 64, 64);
            JobByI.Items[0].ForeColor = Color.WhiteSmoke;
            string CongViecA = "Làm Desktop";
            string CongViecB = "Làm Web";
            JobByI.Items.Add(CongViecA);
            JobByI.Items.Add(CongViecB);
            JobByI.Show(Cursor.Position);


        }

        public int RandomColor(int i)
        {
            Random rd = new Random(unchecked((int)DateTime.Now.Millisecond));
            return rd.Next(i); // Trả về số ngẫu nhiên từ 0 đến i-1
        }

        //void RadomColor()
        //{
        //    //int rnd = RandomColor(2);
        //    foreach (Button btn in pnlMatrix.Controls.OfType<Button>())
        //    {
        //        if (rnd == 0)
        //            btn.BackColor = Color.LightBlue;
        //        else btn.BackColor = Color.DarkBlue;
        //    }

        //    Random rnd = new Random();
        //    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        //    BackColor = randomColor;
        //}

        //void Mau()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        textBox1.Text += RandomColor(2).ToString();

        //    }
        //}

        void ChangeButtonColor(Button btn, DateTime date)
        {
     
            if (date.Day % 4 == 0)
            {
                btn.BackColor = Color.Bisque; 
            }     
        }
    }
}
