﻿using System;
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
using QuanLiSinhVien_DATH.View;

namespace QuanLiSinhVien_DATH
{
    public partial class QuanLiMonHocForm : Form
    {
        private DSSV dssv;
        private DSMH dsmh;
        private int ViTriHienTai = 0;

        public QuanLiMonHocForm(DSSV dssv, DSMH dsmh)
        {
            InitializeComponent();
            this.dssv = dssv;
            this.dsmh = dsmh;
        }
        private void hienthi(DataGridView dgv, List<MonHoc> mh)
        {
            Tinhsoluong();
            dgv.DataSource = mh.ToList();
        }
        private void MonHocForm_Load(object sender, EventArgs e)
        {
            hienthi(dgvMH, dsmh.DSMonHoc);
        }
        private void Tinhsoluong()
        {
            foreach (var mh in dsmh.DSMonHoc)
            {
                mh.Soluong = 0;
                foreach (var sv in dssv.DSsinhvien)
                {
                    if (sv.MonHocDangKy != null)
                    {
                        foreach (var mhdk in sv.MonHocDangKy)
                        {
                            if (mh.MaMH == mhdk.MaMH)
                            {
                                mh.Soluong++;
                            }
                        }
                    }
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMH = txtMaMH.Text;
            mh.TenMH = txtTenMH.Text;
            mh.TinChi = txtSoTC.Text;
            mh.TietLT = txtTietLT.Text;
            mh.TietTH = txtTietTH.Text;
            if(dsmh.kiemTraTrungMa(txtMaMH.Text))
            {
                MessageBox.Show("Mã này đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMH.Focus();
            }
            else
            {
                dsmh.them(mh);
                hienthi(dgvMH, dsmh.DSMonHoc);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Kq = MessageBox.Show("Bạn thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Kq==DialogResult.Yes)
                {
                    this.dsmh.xoaViTri(ViTriHienTai);
                    hienthi(dgvMH, dsmh.DSMonHoc);
                }    
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn đã nhập sai!");
            }
        }

        private void dgvMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ViTriHienTai = e.RowIndex;
            DataGridViewRow row = dgvMH.Rows[ViTriHienTai];
            txtMaMH.Text = dgvMH.Rows[e.RowIndex].Cells["mamh"].Value.ToString();
            txtTenMH.Text = dgvMH.Rows[e.RowIndex].Cells["tenMH"].Value.ToString();
            txtSoTC.Text = dgvMH.Rows[e.RowIndex].Cells["soTC"].Value.ToString();
            txtTietLT.Text = dgvMH.Rows[e.RowIndex].Cells["tietLT"].Value.ToString();
            txtTietTH.Text = dgvMH.Rows[e.RowIndex].Cells["tietTH"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (MonHoc mh in dsmh.DSMonHoc)
            {
                if (mh.MaMH == txtMaMH.Text)
                {
                    mh.MaMH = txtMaMH.Text;
                    mh.TenMH = txtTenMH.Text;
                    mh.TinChi = txtSoTC.Text;
                    mh.TietLT = txtTietLT.Text;
                    mh.TietTH = txtTietTH.Text;
                    hienthi(dgvMH, dsmh.DSMonHoc);
                    MessageBox.Show("Thông Tin Đã Được Cập Nhật");
                    return;
                }
            }
            MessageBox.Show("Không Tìm Thấy MSSV");
        }
        public DSMH File1()
        {
            return dsmh;
        }

        private void dgvMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mh = dgvMH.CurrentRow.Cells["mamh"].Value.ToString();
            DSSV dstt = new DSSV();
            foreach (var sv in dssv.DSsinhvien)
            {
                if (sv.MonHocDangKy != null)
                    foreach (var mhdk in sv.MonHocDangKy)
                {
                    if (mh == mhdk.MaMH)
                    {
                        dstt.them(sv);

                    }
                }
            }
            foreach (var timmh in dsmh.DSMonHoc)
            {
                if (timmh.MaMH == mh)
                {
                    TTSVForm ttsv = new TTSVForm(dstt, timmh.TenMH, "MH");
                    ttsv.ShowDialog();
                }
            }
        }
    }
}
