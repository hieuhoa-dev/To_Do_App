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
    public partial class CalendarForm : Form
    {
        public int DayOfWeek = 7;
        public int DayOfCColumn = 6;
        public int dateButtonWidth = 180;
        public int dateButtonHeight = 57;
        public int margin = 0;


        // Khởi tạo biến ma trận tạo ngày tháng
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dateOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public CalendarForm()
        {
            InitializeComponent();
            LoadMatrix();
            ShowDateOnTop();
        }

        void ShowDateOnTop()
        {
            tsmTime.Text = "Thứ " + dtpkDate.Value.DayOfWeek + ", Ngày " + dtpkDate.Value.Day.ToString() + " ,Tháng " + dtpkDate.Value.Month.ToString()
                + " ,Năm " + dtpkDate.Value.Year.ToString();
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

                    pnlMatrix.Controls.Add(btn);

                    Matrix[i].Add(btn);


                    oldBtn = btn;
                }

                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-margin, oldBtn.Location.Y + dateButtonHeight) };
            }

            SetDefaultDate();
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

                if (isEqualDate(useDate,DateTime.Now))
                    btn.BackColor = Color.Aquamarine;

                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);

            }

        }

        bool isEqualDate(DateTime dateA,DateTime dateB)
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
    }
}
