using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class DSGV
    {
        private List<User> _dsGiaoVien;
        public DSGV()
        {
            _dsGiaoVien = new List<User>();
        }
        public DSGV(List<User> ds)
        {
            _dsGiaoVien = ds;
        }
        public List<User> DSgiaovien
        {
            get { return this._dsGiaoVien; }
            set { _dsGiaoVien = value; }
        }
    }
}
