using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_DATH
{
    public class Data
    {
        public DSSV DanhSachSinhVien { get; set; }     
        public UserGV DanhSachGiaoVien { get; set; }    
        public DSCN DanhSachChuyenNganh { get; set; }
        public DSMH DanhSachMonHoc { get; set; }
        public UserSV TKUserSV { get; set; }
    }
}
