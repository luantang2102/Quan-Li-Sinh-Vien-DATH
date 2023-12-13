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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLiSinhVien_DATH
{
    public partial class DKMHForm : Form
    {
        private DSMH dsmh;
        private DSMH dsmhtmp;
        private DSSV dssv;
        private Data saveData;
        string mssv;
        public DKMHForm(string mssv, DSSV dssv, DSMH dsmh, Data saveData)
        {
            this.mssv = mssv;
            this.dssv = dssv;
            this.dsmh = dsmh;
            this.saveData = saveData;
            InitializeComponent();

        }

        private void DKMH_Load(object sender, EventArgs e)
        {
            txtmssv.Text = mssv;
            addlistbox();

        }
        private void addlistbox()
        {
            foreach(var mh in dsmh.DSMonHoc)
            {
                lb_mh.Items.Add(mh.TenMH);
            }
            foreach (var sv in dssv.DSsinhvien)
            {
                if (sv.MaSV == mssv)
                {
                    if (sv.MonHocDangKy != null)
                    {
                        foreach (var dkmh in sv.MonHocDangKy)
                        {
                            int index = lb_mh.FindStringExact(dkmh.TenMH);
                            if (index != ListBox.NoMatches)
                            {
                                lb_mh.SetItemChecked(index, true);
                            }
                        }
                    }
                }
            }
        }


        private void btn_hien_Click(object sender, EventArgs e)
        {
            dgvdkmh.DataSource = null;
            dsmhtmp = new DSMH();
            foreach (int indexChecker in lb_mh.CheckedIndices)
            {
                foreach (var mh in dsmh.DSMonHoc)
                {
                    if (lb_mh.Items[indexChecker].ToString() == mh.TenMH)
                        dsmhtmp.DSMonHoc.Add(mh);
                } 
            }
            dgvdkmh.DataSource = dsmhtmp.DSMonHoc;
            btn_Luu.Visible = true; 
        }

        private void lb_mh_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            btn_Luu.Visible = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            foreach(var sv in dssv.DSsinhvien)
            {
                if(sv.MaSV == mssv)
                {
                    sv.MonHocDangKy = dsmhtmp.DSMonHoc;
      
                }    
            }
            ghiFile();
            MessageBox.Show("Lưu Thành Công");
        }
        private void ghiFile()
        {
            try
            {
                string filePath = "data.json";
                string jsonFromFile = File.Exists(filePath) ? File.ReadAllText(filePath) : "";
                Data existingData = JsonSerializer.Deserialize<Data>(jsonFromFile) ?? new Data();
                existingData.DanhSachSinhVien = this.dssv;
                string jsonString = JsonSerializer.Serialize(existingData);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
