using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public class DSCongViec
    {
        private List<CongViec> _listItemPlan;
        public List<CongViec> ListItemPlan
        {
            get { return _listItemPlan; }
            set { _listItemPlan = value; }           
        }
    }
}
