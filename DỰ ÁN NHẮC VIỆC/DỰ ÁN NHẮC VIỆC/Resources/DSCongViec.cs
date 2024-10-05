using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DỰ_ÁN_NHẮC_VIỆC
{
    public delegate int SoSanh(object sv1, object sv2);
    public class DSCongViec
    {
        public List<CongViec> DanhSach;

        public DSCongViec()
        {
            DanhSach = new List<CongViec>();
        }


        public void Them(CongViec cv)
        {
            this.DanhSach.Add(cv);
        }

        public CongViec this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }

        public CongViec Tim(object obj, SoSanh ss)
        {
            CongViec svresult = null;
            foreach (CongViec sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }


        public bool Sua(CongViec cvsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = cvsua;
                    kq = true;
                    break;
                }
            return kq;
        }

        public void DocTuFile(string filename)
        {
            string t;
            string[] s;
            CongViec cv;
            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
            {
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split(';');
                    cv = new CongViec();
                    cv.NameJob = s[0];
                    cv.ToDate = DateTime.ParseExact(s[1].Trim(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                    cv.FromDate = DateTime.ParseExact(s[2].Trim(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                    cv.Status = s[3];
                    cv.Level = s[4];
                    string[] cvc = s[5].Split(',');
                    foreach (string c in cvc)
                        cv.DSCongViecCon.Add(c);
                    this.Them(cv);
                }

            }

        }



    }
}
