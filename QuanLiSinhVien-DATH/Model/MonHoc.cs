﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class MonHoc
    {
        private string _mamh;
        private string _tenmh;
        private string _sotc;
        private string _tietlt;
        private string _tietth;
        private int _soluong;

        public string MaMH
        {
            get { return this._mamh; }
            set { this._mamh = value; }
        }
        public string TenMH
        {
            get { return this._tenmh; }
            set { this._tenmh = value; }
        }
        public string TinChi
        {
            get { return this._sotc; }
            set { this._sotc = value; }
        }
        public string TietLT
        {
            get { return this._tietlt; }
            set { this._tietlt = value; }
        }
        public string TietTH
        {
            get { return this._tietth; }
            set { this._tietth = value; }
        }
        public int Soluong
        {
            get { return this._soluong; }
            set { this._soluong = value; }
        }
        public MonHoc()
        {
            this._mamh = "";
            this._tenmh = "";
            this._sotc = "";
            this._tietlt = "";
            this._tietth = "";
            this._soluong = 0;
        }
        public MonHoc(string mamh, string tenmh, string sotc, string tietlt, string tietth, int soluong)
        {
            this._mamh = mamh;
            this._tenmh = tenmh;
            this._sotc = sotc;
            this._tietlt = tietlt;
            this._tietth = tietth;
            this._soluong = soluong;
        }
    }

}
