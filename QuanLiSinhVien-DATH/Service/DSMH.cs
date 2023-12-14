using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class DSMH
    {
        private List<MonHoc> _dsMonHoc;
        public DSMH()
        {
            _dsMonHoc = new List<MonHoc>();
        }
        public DSMH(List<MonHoc> mh)
        {
            _dsMonHoc = mh;
        }
        public List<MonHoc> DSMonHoc
        {
            get { return this._dsMonHoc; }
            set { _dsMonHoc = value; }
        }
        public void them(MonHoc mh)
        {
            _dsMonHoc.Add(mh);
        }
        public void xoa(MonHoc mh)
        {
            this._dsMonHoc.Remove(mh);
        }
        public void xoaViTri(int vitri)
        {
            this._dsMonHoc.RemoveAt(vitri);
        }
        public bool kiemTraTrungMa(string ma)
        {
            foreach (MonHoc mh in this._dsMonHoc)
            {
                if (mh.MaMH.Equals(ma))
                    return true;
            }
            return false;
        }
        public List<MonHoc> hienDSMH()
        {
            return _dsMonHoc;
        }

        public void sua(MonHoc mh, int ViTri)
        {
            this.DSMonHoc[ViTri] = mh;
        }
    }
}
