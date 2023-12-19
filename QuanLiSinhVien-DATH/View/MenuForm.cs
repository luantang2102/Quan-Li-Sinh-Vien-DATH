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
        public DSMH dsmh;
        UserSV userSV = new UserSV();

        private Data saveData;
        private QuanLiSinhVienForm applicationForm;
        private QuanLiChuyenNganhForm chuyenNganhForm;
        private QuanLiMonHocForm monhocform;
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
            applicationForm = new QuanLiSinhVienForm(dssv, dscn);
            AddForm(applicationForm);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monhocform = new QuanLiMonHocForm(dssv,dsmh);
            AddForm(monhocform);
        }

        private void đangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chuyenNganhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuyenNganhForm = new QuanLiChuyenNganhForm(dssv, dscn);
            AddForm(chuyenNganhForm);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            docFile();
            TrangChuForm a = new TrangChuForm();
            AddForm(a);
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ghiFile();
            this.Hide();
            VaiTroForm vaitro = new VaiTroForm();
            vaitro.ShowDialog();
            this.Close();
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
                    this.dscn= fileData;
            }
            if (monhocform != null)
            {
                var fileData = monhocform.File1();
                if(fileData != null)
                    this.dsmh = fileData;
            }    
        }
        private void taotksv()
        {
            userSV = new UserSV();
            foreach(var sv in this.dssv.DSsinhvien)
            {

                User tksv = new User();
                tksv.Username = sv.MaSV;
                tksv.Password = "123";
                userSV.DSUserSV.Add(tksv);
            }    
        }
        private void docFile()
        {
            try
            {  
                string json = File.ReadAllText("..//..//data.json");
                Data data = JsonSerializer.Deserialize<Data>(json);
                this.dssv = data.DanhSachSinhVien;
                this.dscn = data.DanhSachChuyenNganh;
                this.dsmh = data.DanhSachMonHoc;
                this.userSV = data.TKUserSV;
                if (userSV == null)
                {
                    userSV = new UserSV();
                }
                if (dssv == null)
                {
                    dssv = new DSSV();
                }
                if (dscn == null)
                {
                    dscn = new DSCN();
                }
                if (dsmh == null)
                {
                    dsmh = new DSMH();
                }


            }
            catch (Exception ex)
            {
                userSV = new UserSV();
                dssv = new DSSV();
                dscn = new DSCN();
                dsmh = new DSMH();
            }
        }
        private void ghiFile()
        {
            try
            {
                UserSV userSV = new UserSV();
                docds();
                taotksv();
                saveData.DanhSachSinhVien = this.dssv;
                saveData.DanhSachChuyenNganh = this.dscn;
                saveData.TKUserSV = this.userSV;
                saveData.DanhSachMonHoc = this.dsmh;

                string jsonString = JsonSerializer.Serialize(saveData);
                string filePath = "..//..//data.json";

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
