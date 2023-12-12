using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Claims;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace QuanLiSinhVien_DATH
{
    public partial class ApplicationForm : Form
    {
        private DSSV dssv;
        private DSCN dscn;
        private int viTriHienTai = 0;

        public ApplicationForm(DSSV dssv,DSCN dscn)
        {
            this.dssv = dssv;
            this.dscn = dscn;
            InitializeComponent();
            
        }

        private void hienthi(DataGridView dgv, List<SinhVien> sv)
        {
            dgv.DataSource = sv.ToList();
        }
        private void ThemMaCNcbb()
        {
            foreach (var cn in dscn.DSchuyennganh)
            {
                cbb_macn.Items.Add(cn.MaCN);
            }
            if(cbb_macn.Items.Count > 0)
            cbb_macn.SelectedIndex = 0;
        }
        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            ThemMaCNcbb();
            hienthi(dgvdmsv, dssv.DSsinhvien);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            SinhVien sv = new SinhVien();
            sv.MaSV = txtmasv.Text;
            sv.HoTen = txthoten.Text;
            sv.Email = txtemail.Text;
            sv.NgaySinh = dtpngaysinh.Value.Date;

            if (radnam.Checked == true)
            {
                sv.GioiTinh = "Nam";
            }
            else
            {
                sv.GioiTinh = "Nữ";
            }
            sv.DiaChi = txtdiachi.Text;
            sv.SoDT = txtsodt.Text;
            sv.DanToc = txtdt.Text;
            sv.QuocTich = txtqt.Text;
            sv.MaCN = cbb_macn.Text;
            sv.TenCN = txt_TenCN.Text;
            

            if (dssv.kiemTraTrungMa(txtmasv.Text))
            {
                MessageBox.Show("Mã này đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasv.Focus();
            }
            else
            {
                dssv.them(sv);
                hienthi(dgvdmsv, dssv.DSsinhvien);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ketQua = MessageBox.Show("Bạn thực sự muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ketQua == DialogResult.Yes)
                {
                    this.dssv.xoaViTri(viTriHienTai);
                    hienthi(dgvdmsv, dssv.DSsinhvien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai!");
            }
        }


        public DSSV File1()
        {
            return dssv ;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            foreach (SinhVien sv in dssv.DSsinhvien)
            {
                if (sv.MaSV == txtmasv.Text)
                {
                    sv.MaSV = txtmasv.Text;
                    sv.HoTen = txthoten.Text;
                    sv.Email = txtemail.Text;
                    sv.NgaySinh = dtpngaysinh.Value.Date;
                    if (radnam.Checked == true)
                    {
                        sv.GioiTinh = "Nam";
                    }
                    else
                    {
                        sv.GioiTinh = "Nữ";
                    }
                    sv.GioiTinh = radnam.Text;
                    sv.DiaChi = txtdiachi.Text;
                    sv.SoDT = txtsodt.Text;
                    sv.DanToc = txtdt.Text;
                    sv.QuocTich = txtqt.Text;
                    sv.MaCN = cbb_macn.Text;
                    sv.TenCN = txt_TenCN.Text;
                    hienthi(dgvdmsv, dssv.DSsinhvien);
                    MessageBox.Show("Thông Tin Đã Được Cập Nhật");
                    return;
                }

            }
            MessageBox.Show("Không Tìm Thấy MSSV");
        }

        private void dgvdmsv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            viTriHienTai = e.RowIndex;
            DataGridViewRow row = dgvdmsv.Rows[viTriHienTai];
            txtmasv.Text = dgvdmsv.Rows[e.RowIndex].Cells["masv"].Value.ToString();
            txthoten.Text = dgvdmsv.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
            if (dgvdmsv.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString().Equals("Nam"))
            {
                radnam.Checked = true;
            }
            else
            {
                radnu.Checked = true; ;
            }
            dtpngaysinh.Value = (DateTime)dgvdmsv.Rows[e.RowIndex].Cells["ngaysinh"].Value;
            txtdiachi.Text = dgvdmsv.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
            txtemail.Text = dgvdmsv.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtdt.Text = dgvdmsv.Rows[e.RowIndex].Cells["dantoc"].Value.ToString();
            txtqt.Text = dgvdmsv.Rows[e.RowIndex].Cells["quoctich"].Value.ToString();
            txtsodt.Text = dgvdmsv.Rows[e.RowIndex].Cells["sodt"].Value.ToString();
        }

        private void btn_TIm_Click(object sender, EventArgs e)
        {
            TimKiemForm tkf = new TimKiemForm(dssv);
            tkf.ShowDialog();
        }


        private void cbb_macn_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var cn in dscn.DSchuyennganh)
            {
                if (cbb_macn.Text == cn.MaCN)
                {
                    txt_TenCN.Text = cn.TenCN;
                }
            }
        }
    }

}
