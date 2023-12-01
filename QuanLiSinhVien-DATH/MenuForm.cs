using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_DATH
{
    public partial class MenuForm : Form
    {
        private User currentUser;
        public MenuForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationForm applicationForm = new ApplicationForm();
            applicationForm.ShowDialog();
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHocForm monHocForm = new MonHocForm();
            monHocForm.ShowDialog();
        }

        private void đangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void chuyenNganhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChuyenNganhForm chuyenNganhForm = new ChuyenNganhForm();
            chuyenNganhForm.ShowDialog();
        }
    }
}
