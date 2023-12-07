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
            

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChuyenNganh cn = new ChuyenNganh();
            cn.MaCN = txtmacn.Text;
            cn.TenCN = txttenchuyennganh.Text;

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
            dscn = new DSCN();
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            string ndTim = txtTim.Text;

            dgvdscn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                dgvdscn.ClearSelection();
                bool Kiemtra = false;
                int Cot = cbTim.SelectedIndex;
                if (Cot >= 0 && Cot < dgvdscn.Columns.Count)
                {
                    for (int i = 0; i < dgvdscn.Rows.Count; i++)
                    {
                        DataGridViewCell cell = dgvdscn.Rows[i].Cells[Cot];
                        if (cell.Value != null && cell.Value.ToString().Equals(ndTim))
                        {
                            dgvdscn.Rows[i].Selected = true;
                            Kiemtra = true;
                        }
                    }
                }
                if (!Kiemtra)
                {
                    MessageBox.Show("Không thể tìm thấy nội dung" + txtTim.Text, "Thông báo");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
