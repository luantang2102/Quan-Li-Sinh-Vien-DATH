using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QuanLiSinhVien_DATH
{
    public class UserSV
    {
        private List<User> _dsusersv;
        public UserSV()
        {
            _dsusersv = new List<User>();
        }
        public UserSV(List<User> ds)
        {
            _dsusersv = ds;
        }
        public List<User> DSUserSV
        {
            get { return this._dsusersv; }
            set { _dsusersv = value; }
        }
    }
}
