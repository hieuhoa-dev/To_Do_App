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

        public string NameJob { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }

        public string Status { get; set; }

        public List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED" };

        public enum ListStatusItem
        {
            DONE,
            DOING,
            COMING,
            MISSED
        }
        public string Level { get; set; }

        public List<string> ListLevel = new List<string>() { "Important", "Normal", "Weak", "None" };

        public enum ListLevelItem
        {
            DONE,
            DOING,
            COMING,
            MISSED
        }
        public List<string> DSCongViecCon { get; set; }
        public CongViec()
        {
            DSCongViecCon = new List<string>();
        }
        public CongViec(string NameJob, DateTime ToDate, DateTime FromDate,
        string Status, string Level, List<string> DSCongViecCon)
        {
            this.NameJob = NameJob;
            this.ToDate = ToDate;
            this.FromDate = FromDate;
            this.Status = Status;
            this.Level = Level;
            this.DSCongViecCon = DSCongViecCon;
        }





    }
}
