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
        private Data saveData;
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
            ApplicationForm applicationForm = new ApplicationForm(saveData);
            AddForm(applicationForm);
            //applicationForm.ShowDialog();
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
            ChuyenNganhForm a = new ChuyenNganhForm();
            AddForm(a);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            WelcomeForm a = new WelcomeForm();
            AddForm(a);
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemForm tk = new TimKiemForm();
            AddForm(tk);
        }
    }
}
