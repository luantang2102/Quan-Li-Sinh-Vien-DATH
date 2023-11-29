using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class MonHoc
    {
        private string m_mamh;
        private string m_tenmh;
        private string m_sotc;
        private string m_tietlt;
        private string m_tietth;

        public string MaMH
        {
            get { return m_mamh; }
            set { m_mamh = value; }
        }
        public string TenMH
        {
            get { return m_tenmh; }
            set { m_tenmh = value; }
        }
        public string TinChi
        {   get { return m_sotc;}
            set { m_sotc = value; }
        }
        public string TietLT
        {   get { return m_tietlt;}
            set { m_tietlt = value; }
        }
        public string TietTH
        {
            get { return m_tietth;}
            set { m_tietth = value;}
        }
        public MonHoc()
        {
            m_mamh = "";
            m_tenmh = "";
            m_sotc = "";
            m_tietlt = "";
            m_tietth = "";
        }
        public MonHoc(string mamh, string tenmh, string sotc, string tietlt, string tietth)
        {
            m_mamh = mamh;
            m_tenmh = tenmh;
            m_sotc = sotc;
            m_tietlt = tietlt;
            m_tietth = tietth;
        }
    }

}
