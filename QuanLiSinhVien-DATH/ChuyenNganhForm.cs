using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_DATH
{
    public partial class ChuyenNganhForm : Form
    {
        private DSSV dssv;
        private DSCN dscn;
        private int VT = 0;
        public ChuyenNganhForm(DSSV dssv, DSCN dscn)
        {
            this.dssv = dssv;
            this.dscn = dscn;
            InitializeComponent();
        }
        private void Tinhsoluong()
        {
            foreach (var cn in dscn.DSchuyennganh)
                {
                cn.Soluong = 0;
                    foreach (var sv in dssv.DSsinhvien)
                    {
                        if (cn.MaCN == sv.MaCN)
                        {
                            cn.Soluong++;
                        }
                    }
                }
        }
        private void hienthi(DataGridView dgv, List<ChuyenNganh> cn)
        {
            Tinhsoluong();
            dgv.DataSource = cn.ToList();
        }

        private void dgvdscn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            VT = e.RowIndex;
            DataGridViewRow row = dgvdscn.Rows[VT];
            txtmacn.Text = dgvdscn.Rows[e.RowIndex].Cells["MaChuyenNganh"].Value.ToString();
            txttenchuyennganh.Text = dgvdscn.Rows[e.RowIndex].Cells["TenChuyenNganh"].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChuyenNganh cn = new ChuyenNganh();
            cn.MaCN = txtmacn.Text;
            cn.TenCN = txttenchuyennganh.Text;

            if (dscn.kiemTraTrungMa(txtmacn.Text, txttenchuyennganh.Text))
            {
                MessageBox.Show("Ma Hoac Ten nay da co", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacn.Focus();
            }
            else
            {
                dscn.them(cn);
                hienthi(dgvdscn, dscn.DSchuyennganh);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kQ = MessageBox.Show("Ban thuc su muon xoa?,", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(kQ==DialogResult.Yes)
                {
                    this.dscn.xoaViTri(VT);
                    hienthi(dgvdscn, dscn.DSchuyennganh);
                }    
            }
            catch(Exception)
            {
                MessageBox.Show("bạn đã nhập sai!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach(ChuyenNganh cn in dscn.DSchuyennganh)
            {
                if(cn.MaCN==txtmacn.Text)
                {
                    cn.MaCN = txtmacn.Text;
                    cn.TenCN = txttenchuyennganh.Text;
                    hienthi(dgvdscn, dscn.DSchuyennganh);
                    MessageBox.Show("Thông Tin Đã Được Cập Nhật");
                    return;
                }    
            }
            MessageBox.Show("Không Tìm Thấy MSSV");
        }

        private void ChuyenNganhForm_Load(object sender, EventArgs e)
        {
            cbTim.SelectedIndex = 0;
            hienthi(dgvdscn, dscn.DSchuyennganh);
        }

        public DSCN File1()
        {
            return dscn;
        }

    
        private void btnTim_Click_1(object sender, EventArgs e)
        {
            dgvdscn.DataSource = null;
            try
            {
                string Tim = txtTim.Text;
                string CotTim = cbTim.Text;
                CotTim = XoaDauvaKhoangTrang(CotTim);
                foreach (var cn in dscn.DSchuyennganh)
                {
                    var dlTim = cn.GetType().GetProperty(CotTim)?.GetValue(cn);
                    if (dlTim != null && dlTim.ToString() == Tim)
                    {
                        dgvdscn.DataSource = dscn.DSchuyennganh.Where(s => cn.GetType().GetProperty(CotTim).GetValue(s).ToString() == Tim).ToList();
                    }
                }
                dgvdscn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã số này.", "Thông báo");
            }
        }
        static string XoaDauvaKhoangTrang(string Text)
        {
            // Loại bỏ dấu
            string bodau = Text.Normalize(NormalizationForm.FormKD);
            Regex regex = new Regex("[^a-zA-Z0-9]");
            string withoutAccents = regex.Replace(bodau, "");

            // Loại bỏ khoảng trắng
            string xoaKT = withoutAccents.Replace(" ", "");

            return xoaKT;
        }

        private void hiends_Click(object sender, EventArgs e)
        {
            try
            {
                dgvdscn.DataSource = dscn.DSchuyennganh;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
    }
}
