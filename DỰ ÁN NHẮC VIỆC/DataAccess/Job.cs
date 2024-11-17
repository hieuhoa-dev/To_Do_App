using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Job
    {
        public int ID { get; set; }
        public string NameJob { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }

        public int Status { get; set; } // 1 check: hoàng thành, 2, nocheck: chưa hoàn thành
        public string Category { get; set; }

        public int LevelJob { get; set; }// 1: quan trọng, 0: không quan trọng

        public List<string> ListLevel = new List<string>() { "Important", "None" };

        public string Notes { get; set; }

    }
}
