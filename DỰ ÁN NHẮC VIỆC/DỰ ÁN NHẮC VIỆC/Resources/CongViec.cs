using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public class CongViec
    {
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }

        }

        private string nameJob;
        public string NameJob
        {
            get { return nameJob; }
            set { nameJob = value; }
        }

        private Point fromTime;
        public Point FromTime
        {
            get { return fromTime; }
            set { fromTime = value; }
        }

        private Point toTime;
        public Point ToTime
        {
            get { return toTime; }
            set { toTime = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED" };

        public enum Plan
        {
            Done,
            DOING,
            COMING,
            MISSED
        }

        private string level;
        public string Level
        {
            get { return level; }
            set { status = value; }
        }
        public static List<string> ListLevel = new List<string>() { "Important", "Normal", "Weak", "None" };
    }
}
