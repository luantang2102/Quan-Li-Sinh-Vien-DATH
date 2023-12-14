using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class UserGV
    {
        private List<User> _dsGiaoVien;
        public UserGV()
        {
            _dsGiaoVien = new List<User>();
        }
        public UserGV(List<User> ds)
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
