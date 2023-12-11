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
    public partial class MenuForm : Form
    {
        public DSSV dssv;
        public DSCN dscn;
        private Data saveData;
        private ApplicationForm applicationForm;
        private ChuyenNganhForm chuyenNganhForm;
        public MenuForm(Data saveData)
        {
            this.saveData = saveData;
            InitializeComponent();
            

        }
        public void AddForm(Form a)
        {
            this.panel1.Controls.Clear();
            a.TopLevel = false;
            a.AutoScroll = true;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            this.Text = a.Text;
            this.panel1.Controls.Add(a);
            a.Show();
        }
        public void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicationForm = new ApplicationForm(dssv, dscn);
            AddForm(applicationForm);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHocForm a = new MonHocForm();
            AddForm(a);
        }

        private void đangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void chuyenNganhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuyenNganhForm = new ChuyenNganhForm(dssv, dscn);
            AddForm(chuyenNganhForm);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            docFile();
            WelcomeForm a = new WelcomeForm();
            AddForm(a);
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ghiFile();
            Application.Exit();
        }

        private void quảnLýToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                docds();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}");
            }
        }
        private void docds()
        {
            if (applicationForm != null)
            {
                var fileData = applicationForm.File1();
                if (fileData != null)
                    this.dssv = fileData;
            }
            if (chuyenNganhForm != null)
            {
                var fileData = chuyenNganhForm.File1();
                if (fileData != null)
                    this.dscn = fileData;
            }
        }
        private void docFile()
        {
            try
            {
                string json = File.ReadAllText("data.json");
                Data data = JsonSerializer.Deserialize<Data>(json);
                this.dssv = data.DanhSachSinhVien;
                this.dscn = data.DanhSachChuyenNganh;

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
                docds();
                saveData.DanhSachSinhVien = this.dssv;
                saveData.DanhSachChuyenNganh = this.dscn;

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
    }
}
