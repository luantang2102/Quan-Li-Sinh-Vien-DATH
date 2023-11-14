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
    public partial class ApplicationForm : Form
    {
        private User currentUser;
        public ApplicationForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }
    }
}
