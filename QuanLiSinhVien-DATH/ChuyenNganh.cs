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
        private int _soluong;



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
        public int Soluong
        {
            get { return this._soluong; }
            set { this._soluong = value; }
        }
     
        public ChuyenNganh()
        {
            this._macn = "";
            this._tenchuyennganh = "";
            this._soluong = 0;
          ;
        }
        public ChuyenNganh(string macn, string tenchuyennganh, int soluong)
        {
            this._macn = macn;
            this._tenchuyennganh = tenchuyennganh;
            this._soluong = soluong;
           
        }
    }
}
