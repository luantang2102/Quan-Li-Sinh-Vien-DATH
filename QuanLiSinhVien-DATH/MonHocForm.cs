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
    public partial class MonHocForm : Form
    {
        private List<MonHoc> dsMH;
        private void hienthi()
        {
            dgvMH.DataSource = dsMH.ToList();
        }
        private MonHoc timMH(string mamh)
        {
            foreach (MonHoc item in dsMH)
            {
                if(item.MaMH == mamh)
                    return item;
            }
            return null;
        }
        public MonHocForm()
        {
            InitializeComponent();
        }

        private void dgvMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvMH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoTC.Text = dgvMH.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTietLT.Text = dgvMH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTietTH.Text = dgvMH.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMH = txtMaMH.Text;
            mh.TenMH = txtTenMH.Text;
            mh.TinChi= txtSoTC.Text;
            mh.TietLT = txtTietLT.Text;
            mh.TietTH = txtTietTH.Text;
            dsMH.Add(mh);
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for(int i=0; i<dsMH.Count; i++)
            {
                if (dsMH[i].MaMH== txtMaMH.Text)
                {
                    dsMH.RemoveAt(i);
                    break;
                }
            }
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dsMH.Count; i++) 
            { 
                if (dsMH[i].MaMH==txtMaMH.Text)
                {
                    dsMH[i].TenMH = txtTenMH.Text;
                    dsMH[i].TinChi = txtSoTC.Text;
                    dsMH[i].TietLT = txtTietLT.Text;
                    dsMH[i].TietTH = txtTietTH.Text;
                    break;
                }
            }
            hienthi() ;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
