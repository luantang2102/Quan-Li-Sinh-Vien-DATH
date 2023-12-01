using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class ChuyenNganh
    {
        private string _macn;
        private string _tenchuyennganh;
        private string _soluong;


        //properties
        public string MaCN
        {
            get { return this._macn; }
            set { this._macn = value; }
        }
        public string TenCN
        {
            get { return this._tenchuyennganh; }
            set { this._tenchuyennganh = value; }
        }
        public string SoLuong
        {
            get { return this._soluong; }
            set { this._soluong = value; }
        }
        public ChuyenNganh()
        {
            this._macn = "";
            this._tenchuyennganh = "";
            this._soluong = "";
        }
        public ChuyenNganh(string macn, string tenchuyennganh, string soluong)
        {
            this._macn = macn;
            this._tenchuyennganh = tenchuyennganh;
            this._soluong = soluong;
        }
    }
}
