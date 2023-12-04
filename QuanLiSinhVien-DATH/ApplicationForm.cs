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

namespace QuanLiSinhVien_DATH
{
    public partial class ApplicationForm : Form
    {
        private DSSV dssv;
        private int viTriHienTai = 0;
        private User currentUser;

        private Data saveData;

        public ApplicationForm(/*User currentUser,*/ /*Data saveData*/)
        {
            //this.currentUser = currentUser;
            //this.saveData = saveData;   
            InitializeComponent();

        }

        private void hienthi(DataGridView dgv, List<SinhVien> sv)
        {
            dgv.DataSource = sv.ToList();
        }

        private void docFile()
        {
            try
            {
                string json = File.ReadAllText("data.json");
                Data data = JsonSerializer.Deserialize<Data>(json);
                this.dssv = data.DanhSachSinhVien;
                
            }
            catch (Exception ex)
            {
                dssv = new DSSV();
            }
        }
        
        private void ghiFile()
        {
            try
            {
                saveData.DanhSachSinhVien = this.dssv;
                   
                string jsonString = JsonSerializer.Serialize(saveData);
                string filePath = "data.json";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {

            }
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            docFile();
            hienthi(dgvdmsv, dssv.DSsinhvien);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            SinhVien sv = new SinhVien();
            sv.MaSV = txtmasv.Text;
            sv.HoTen = txthoten.Text;
            sv.Email = txtemail.Text;
            sv.NgaySinh = dtpngaysinh.Value;

            if (radnam.Checked == true)
            {
                sv.GioiTinh = "Nam";
            }
            else
            {
                sv.GioiTinh = "Nữ";
            }
            sv.Diachi = txtdiachi.Text;
            sv.Sodt = txtsodt.Text;

            if (dssv.kiemTraTrungMa(txtmasv.Text))
            {
                MessageBox.Show("ma nay da co", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult ketQua = MessageBox.Show("Ban thuc su muon xoa?,", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ketQua == DialogResult.Yes)
                {
                    this.dssv.xoaViTri(viTriHienTai);
                    hienthi(dgvdmsv, dssv.DSsinhvien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("bạn đã nhập sai!");
            }
        }

        private void dgvdmsv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            viTriHienTai = e.RowIndex;
            DataGridViewRow row = dgvdmsv.Rows[viTriHienTai];
            txtmasv.Text = dgvdmsv.Rows[e.RowIndex].Cells["masv"].Value.ToString();
            txthoten.Text = dgvdmsv.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
            txtemail.Text = dgvdmsv.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtdiachi.Text = dgvdmsv.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
            if (dgvdmsv.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString().Equals("Nam"))
            {
                radnam.Checked = true;
            }
            else
            {
                radnu.Checked = true; ;
            }

            dtpngaysinh.Value = (DateTime)dgvdmsv.Rows[e.RowIndex].Cells["ngaysinh"].Value;
            txtsodt.Text = dgvdmsv.Rows[e.RowIndex].Cells["sodt"].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = txtmasv.Text;
            sv.HoTen = txthoten.Text;
            sv.Email = txtemail.Text;
            sv.NgaySinh = dtpngaysinh.Value;
            sv.GioiTinh = radnam.Text;
            sv.Diachi = txtdiachi.Text;
            sv.Sodt = txtsodt.Text;
            dssv.sua(sv, viTriHienTai);
            hienthi(dgvdmsv, dssv.DSsinhvien);
        }


        private void btTim_Click(object sender, EventArgs e)
        {
            string ndTim = txtTim.Text;

            dgvdmsv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                dgvdmsv.ClearSelection();
                bool Kiemtra = false;
                int Cot = cbTim.SelectedIndex;
                if (Cot >= 0 && Cot < dgvdmsv.Columns.Count)
                {
                    for (int i = 0; i < dgvdmsv.Rows.Count; i++)
                    {
                        DataGridViewCell cell = dgvdmsv.Rows[i].Cells[Cot];
                        if (cell.Value != null && cell.Value.ToString().Equals(ndTim))
                        {
                            dgvdmsv.Rows[i].Selected = true;
                            Kiemtra = true;
                        }
                    }
                }
                if (!Kiemtra)
                {
                    MessageBox.Show("Nội Dung: " + txtTim.Text, "Không Thể Tìm thấy");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ApplicationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ghiFile();
        }
    }

}
