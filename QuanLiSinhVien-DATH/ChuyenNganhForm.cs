using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_DATH
{
    public partial class ChuyenNganhForm : Form
    {
        private DSCN dscn;
        private int VT = 0;
        public ChuyenNganhForm()
        {
            InitializeComponent();
        }
        private void hienthi(DataGridView dgv, List<ChuyenNganh> cn)
        {
            dgv.DataSource = cn.ToList();
        }

        private void dgvdscn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            VT = e.RowIndex;
            DataGridViewRow row = dgvdscn.Rows[VT];
            txtmacn.Text = dgvdscn.Rows[e.RowIndex].Cells["macn"].Value.ToString();
            txttenchuyennganh.Text = dgvdscn.Rows[e.RowIndex].Cells["tenchuyennganh"].Value.ToString();
            txtsoluong.Text = dgvdscn.Rows[e.RowIndex].Cells["soluong"].Value.ToString();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChuyenNganh cn = new ChuyenNganh();
            cn.MaCN = txtmacn.Text;
            cn.TenCN = txttenchuyennganh.Text;
            cn.SoLuong = txtsoluong.Text;

            if (dscn.kiemTraTrungMa(txtmacn.Text))
            {
                MessageBox.Show("ma nay da co", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ChuyenNganh cn = new ChuyenNganh();
            cn.MaCN = txtmacn.Text;
            cn.TenCN = txttenchuyennganh.Text;
            cn.SoLuong = txtsoluong.Text;
            dscn.sua(cn, VT);
            hienthi(dgvdscn, dscn.DSchuyennganh);
        }

        private void ChuyenNganhForm_Load(object sender, EventArgs e)
        {
            dscn = new DSCN();
        }
    }
}
