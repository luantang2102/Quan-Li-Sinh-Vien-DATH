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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace QuanLiSinhVien_DATH
{
    public partial class TimKiemForm : Form
    {
        private DSSV dssv;
        public TimKiemForm(DSSV dssv)
        {
            this.dssv = dssv;
            InitializeComponent();
        }
        public Data DuLieuForm { get; set; }

            private void btn_Tim_Click(object sender, EventArgs e)
            {
            dgvTim.DataSource = null;
            try
            {
                string Tim = txtndTim.Text;
                string CotTim = cBTim.Text;
                CotTim = XoaDauvaKhoangTrang(CotTim);
                foreach (var sinhvien in dssv.DSsinhvien)
                {
                    var dlTim = sinhvien.GetType().GetProperty(CotTim)?.GetValue(sinhvien);
                    if (dlTim != null && dlTim.ToString() == Tim)
                    {
                        dgvTim.DataSource = dssv.DSsinhvien.Where(s => sinhvien.GetType().GetProperty(CotTim).GetValue(s).ToString() == Tim).ToList();
                    }
                }
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

        private void btHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTim.DataSource = dssv.DSsinhvien;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void TimKiemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
