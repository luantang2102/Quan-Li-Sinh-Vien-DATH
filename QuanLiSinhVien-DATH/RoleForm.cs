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
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void btn_GV_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm user = new UserForm();
            user.ShowDialog();
            this.Close();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSVForm user = new UserSVForm();
            user.ShowDialog();
            this.Close();
        }
    }
}
