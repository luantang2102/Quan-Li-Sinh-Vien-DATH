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
        //private MonHoc timMH(string mamh)
        //{
        //    foreach (MonHoc item in dsMH)
        //    {
        //        if(item.MaMH == mamh)
        //            return item;
        //    }
        //    return null;
        //}
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
            MonHoc n = new MonHoc();
            n.MaMH = txtMaMH.Text;
            n.TenMH = txtTenMH.Text;
            n.TinChi= txtSoTC.Text;
            n.TietLT = txtTietLT.Text;
            n.TietTH = txtTietTH.Text;
            dsMH.Add(n);
            hienthi();
            //if (timMH(n.MaMH) == null)
            //{
            //    dsMH.Add(n);
            //    hienthi();
            //}
            //else
            //    MessageBox.Show("Ma mon hoc " + n.MaMH + " da ton tai. Khong them duoc.");
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

        private void MonHocForm_Load(object sender, EventArgs e)
        {
            dsMH = new List<MonHoc>();
            hienthi();
        }
    }
}
