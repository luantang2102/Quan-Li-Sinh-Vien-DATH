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

namespace QuanLiSinhVien_DATH
{
    public partial class MonHocForm : Form
    {
        //private List<MonHoc> dsMH;
        private DSMH dsmh;
        private int ViTriHienTai = 0;

        public MonHocForm()
        {
            InitializeComponent();
        }
        private void hienthi(DataGridView dgv, List<MonHoc> mh)
        {
            dgv.DataSource = mh.ToList();
        }
        //private MonHoc timMH(string mamh)
        //{
        //    foreach (MonHoc item in dsmh)
        //    {
        //        if (item.MaMH == mamh)
        //            return item;
        //    }
        //    return null;
        //}
        private void dgvMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ViTriHienTai = e.RowIndex;
            DataGridViewRow row = dgvMH.Rows[ViTriHienTai];
            txtMaMH.Text = dgvMH.Rows[e.RowIndex].Cells["mamh"].Value.ToString();
            txtTenMH.Text = dgvMH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString();
            txtSoTC.Text = dgvMH.Rows[e.RowIndex].Cells["soTC"].Value.ToString();
            txtTietLT.Text = dgvMH.Rows[e.RowIndex].Cells["tietLT"].Value.ToString();
            txtTietTH.Text = dgvMH.Rows[e.RowIndex].Cells["tietTH"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMH = txtMaMH.Text;
            mh.TenMH = txtTenMH.Text;
            mh.TinChi= txtSoTC.Text;
            mh.TietLT = txtTietLT.Text;
            mh.TietTH = txtTietTH.Text;

            if (dsmh.kiemTraTrungMa(txtMaMH.Text))
            {
                MessageBox.Show("ma nay da co", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult ketQua = MessageBox.Show("Ban thuc su muon xoa?,", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ketQua == DialogResult.Yes)
                {
                    this.dsmh.xoaViTri(ViTriHienTai);
                    hienthi(dgvMH, dsmh.DSMonHoc);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("bạn đã nhập sai!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMH = txtMaMH.Text;
            mh.TenMH =txtTenMH .Text;
            mh.TinChi =txtSoTC .Text;
            mh.TietLT = txtTietLT.Text;
            mh.TietTH = txtTietTH.Text;
            dsmh.sua(mh, ViTriHienTai);
            hienthi(dgvMH, dsmh.DSMonHoc);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void MonHocForm_Load(object sender, EventArgs e)
        {
            dsmh=new DSMH();
        }
    }
}