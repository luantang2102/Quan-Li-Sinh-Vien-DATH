using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class SinhVien
    {
        private string _masv;
        private string _hoten;
        private string _email;
        private DateTime _ngaysinh;
        private string _gioitinh;
        private string _diachi;
        private string _sodt;

        //properties
        public string MaSV
        {
            get { return this._masv; }
            set { this._masv = value; }
        }
        public string HoTen
        {
            get { return this._hoten; }
            set { this._hoten = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public DateTime NgaySinh
        {
            get { return this._ngaysinh; }
            set { this._ngaysinh = value; }
        }
        public string GioiTinh
        {
            get { return _gioitinh; }
            set { this._gioitinh = value; }
        }
        public string Sodt
        {
            get { return this._sodt; }
            set { this._sodt = value; }
        }
        public string Diachi
        {
            get { return this._diachi; }
            set { this._diachi = value; }
        }

        //các phương thức tạo lập 
        //pttl không tham số
        public SinhVien()
        {
            this._masv = "";
            this._email = "";
            this._hoten = "";
            this._ngaysinh = DateTime.Now;
            this._gioitinh = "";
            this._diachi = "";
            this._sodt = "";
        }
        // pttl có tham số
        public SinhVien(string masv, string email, string hoten,
            string diachi, string sodt, DateTime ngaysinh, string gioitinh)
        {
            this._masv = masv;
            this._email = email;
            this._hoten = hoten;
            this._diachi = diachi;
            this._sodt = sodt;
            this._ngaysinh = ngaysinh;
            this._gioitinh = GioiTinh;
        }

    }
}


