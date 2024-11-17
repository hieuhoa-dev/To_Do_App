using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobChild 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int JobID { get; set; }
 
    } 
}
