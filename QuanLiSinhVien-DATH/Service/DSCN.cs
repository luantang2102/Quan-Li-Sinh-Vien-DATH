using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class DSCN
    {
        private List<ChuyenNganh> _dsChuyenNganh;
        public DSCN()
        {
            _dsChuyenNganh = new List<ChuyenNganh>();
        }
        public DSCN(List<ChuyenNganh> ds)
        {
            _dsChuyenNganh = ds;
        }
        public List<ChuyenNganh> DSchuyennganh
        {
            get { return this._dsChuyenNganh; }
            set { _dsChuyenNganh = value; }
        }
        public void them(ChuyenNganh cn)
        {
            _dsChuyenNganh.Add(cn);
        }
        public void xoa(ChuyenNganh cn)
        {
            this._dsChuyenNganh.Remove(cn);
        }
        public void xoaViTri(int vitri)
        {
            this._dsChuyenNganh.RemoveAt(vitri);
        }
        public bool kiemTraTrungMa(string ma, string ten)
        {
            foreach (ChuyenNganh cn in this._dsChuyenNganh)
            {
                if (cn.MaCN.Equals(ma)||cn.TenCN.Equals(ten))
                    return true;
            }
            return false;
        }
        public List<ChuyenNganh> hienDSCN()
        {
            return _dsChuyenNganh;
        }
        public void sua(ChuyenNganh cn, int ViTri)
        {
            this.DSchuyennganh[ViTri] = cn;
        }
    }
}
