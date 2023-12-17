using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_DATH.View
{
    public partial class TTSVForm : Form
    {
        DSSV dstt;
        string Ten;
        public TTSVForm(DSSV dstt, string Ten, string Tenfunc)
        {
            this.dstt = dstt;
            InitializeComponent();
            this.Ten = Ten;
            if (Tenfunc == "MH")
            {
                label1.Text = "Tên Môn Học: ";
            }
            if(Tenfunc == "CN")
            {
                label1.Text = "Tên Chuyên Ngành: ";
            }    
        }

        private void TTSV_Load(object sender, EventArgs e)
        {
            txtTen.Text = Ten;
            foreach (var sv in dstt.DSsinhvien)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = sv.MaSV;
                row.Cells[1].Value = sv.HoTen;
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
