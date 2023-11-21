using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    class DSSV
    {

        private List<SinhVien> _dsSinhVien;
        public DSSV()
        {
            _dsSinhVien = new List<SinhVien>();
        }
        public DSSV(List<SinhVien> ds)
        {
            _dsSinhVien = ds;
        }
        public List<SinhVien> DSsinhvien
        {
            get { return this._dsSinhVien; }
            set { _dsSinhVien = value; }
        }
        public void them(SinhVien sv)
        {
            _dsSinhVien.Add(sv);
        }
        public void xoa(SinhVien sv)
        {
            this._dsSinhVien.Remove(sv);
        }
        public void xoaViTri(int vitri)
        {
            this._dsSinhVien.RemoveAt(vitri);
        }
        public bool kiemTraTrungMa(string ma)
        {
            foreach (SinhVien sv in this._dsSinhVien)
            {
                if (sv.MaSV.Equals(ma))
                    return true;
            }
            return false;
        }
        public List<SinhVien> hienDSSV()
        {
            return _dsSinhVien;
        }

        public void sua(SinhVien sv, int ViTri)
        {
            this.DSsinhvien[ViTri] = sv;
        }

    }


}
