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

namespace QuanLiSinhVien_DATH
{
    public partial class TimKiemForm : Form
    {
        public TimKiemForm()
        {
            InitializeComponent();
        }
        public Data DuLieuForm { get; set; }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText("data.json");
                Data data = JsonSerializer.Deserialize<Data>(json);
                string Tim = txtndTim.Text;
                bool foundData = false;
                string CotTim = cBTim.Text;
                CotTim = XoaDauvaKhoangTrang(CotTim);
                if (Tim != "")
                {
                    if (data != null && data.DanhSachSinhVien != null && data.DanhSachSinhVien.DSsinhvien != null)
                    {

                        // Tạo DataTable để lưu dữ liệu cho DataGridView
                        var dataTable = new System.Data.DataTable();
                        dataTable.Columns.Add("Mã SV");
                        dataTable.Columns.Add("Họ Tên");
                        dataTable.Columns.Add("Giới Tính");
                        dataTable.Columns.Add("Ngày Sinh");
                        dataTable.Columns.Add("Địa Chỉ");
                        dataTable.Columns.Add("Email");
                        dataTable.Columns.Add("Dân Tộc");
                        dataTable.Columns.Add("Quốc Tịch");
                        dataTable.Columns.Add("Số Điện Thoại");
                       

                        foreach (var sinhvien in data.DanhSachSinhVien.DSsinhvien)
                        {
                            var propertyValue = sinhvien.GetType().GetProperty(CotTim).GetValue(sinhvien);
                            if (propertyValue.ToString() == Tim)
                            {
                                // Thêm dữ liệu vào DataTable
                                dataTable.Rows.Add(
                                        sinhvien.MaSV,
                                        sinhvien.HoTen,
                                        sinhvien.GioiTinh,
                                        sinhvien.NgaySinh,
                                        sinhvien.DiaChi,
                                        sinhvien.Email,
                                        sinhvien.DanToc,
                                        sinhvien.QuocTich,
                                        sinhvien.SoDT
                            );
                                foundData = true;
                            }
                        }

                        if (!foundData)
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu cho " + Tim, "Thông báo");
                        }
                        // Gán DataTable làm nguồn dữ liệu cho DataGridView
                        dgvTim.DataSource = dataTable;
                    }
                }
                else
                    MessageBox.Show("Vui Lòng Nhập Nội Dung TÌm Kiếm", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
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
                string json = File.ReadAllText("data.json");
                Data data = JsonSerializer.Deserialize<Data>(json);

                if (data != null && data.DanhSachSinhVien != null && data.DanhSachSinhVien.DSsinhvien != null)
                {
                    // Tạo DataTable để lưu dữ liệu cho DataGridView
                    var dataTable = new System.Data.DataTable();
                    dataTable.Columns.Add("Mã SV");
                    dataTable.Columns.Add("Họ Tên");
                    dataTable.Columns.Add("Giới Tính");
                    dataTable.Columns.Add("Ngày Sinh");
                    dataTable.Columns.Add("Địa Chỉ");
                    dataTable.Columns.Add("Email");
                    dataTable.Columns.Add("Dân Tộc");
                    dataTable.Columns.Add("Quốc Tịch");
                    dataTable.Columns.Add("Số Điện Thoại");
                   

                    foreach (var sinhvien in data.DanhSachSinhVien.DSsinhvien)
                    {
                        // Thêm dữ liệu vào DataTable
                        dataTable.Rows.Add(
                            sinhvien.MaSV,
                            sinhvien.HoTen,
                            sinhvien.GioiTinh,
                            sinhvien.NgaySinh,
                            sinhvien.DiaChi,
                            sinhvien.Email,
                            sinhvien.DanToc,
                            sinhvien.QuocTich,
                            sinhvien.SoDT
                            );
                    }

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvTim.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
    }
}
