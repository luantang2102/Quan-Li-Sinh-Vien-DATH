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
        private Data saveData;

        public ApplicationForm(Data saveData)
        {
            this.saveData = saveData;   
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
            sv.DiaChi = txtdiachi.Text;
            sv.SoDT = txtsodt.Text;
            sv.DanToc = txtdt.Text;
            sv.QuocTich = txtqt.Text;
            sv.MaCN = txtmcn.Text;
            sv.TenCN = txttencn.Text;

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
            ghiFile();
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

        private void dgvdmsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            txtmcn.Text = dgvdmsv.Rows[e.RowIndex].Cells["macn"].Value.ToString();
            txttencn.Text = dgvdmsv.Rows[e.RowIndex].Cells["tencn"].Value.ToString();
        }
        

        private void ApplicationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ghiFile();
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
                    sv.NgaySinh = dtpngaysinh.Value;
                    sv.GioiTinh = radnam.Text;
                    sv.DiaChi = txtdiachi.Text;
                    sv.SoDT = txtsodt.Text;
                    sv.DanToc = txtdt.Text;
                    sv.QuocTich = txtqt.Text;
                    sv.MaCN = txtmcn.Text;
                    sv.TenCN = txttencn.Text;
                    hienthi(dgvdmsv, dssv.DSsinhvien);
                    MessageBox.Show("Thông Tin Đã Được Cập Nhật");
                    return;
                }

            }
            MessageBox.Show("Không Tìm Thấy MSSV");
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            TimKiemForm tk = new TimKiemForm();
            tk.Show();

        }
    }

}
