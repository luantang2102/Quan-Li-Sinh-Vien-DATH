using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_DATH
{
    public partial class DangNhapSVForm : Form
    {
        UserSV userSV;
        DSSV dssv;
        DSMH dsmh;
        Data DKMHuser = new Data();
        private Data saveData = new Data();
        public DangNhapSVForm()
        {
            docFile();
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userSV.DSUserSV.Any() != true)
            {
                MessageBox.Show("Chưa có tài khoản trong cơ sở dữ liệu");
                return;
            }
            foreach (User user in userSV.DSUserSV)
            {
                if (user.Username.Equals(usernameTB.Text) && user.Password.Equals(passwordTB.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    DangKyMonHocForm dkmh = new DangKyMonHocForm(usernameTB.Text, dssv , dsmh, saveData);
                    dkmh.ShowDialog();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            usernameTB.Text = "";
            passwordTB.Text = "";
        }


        private void docFile()
        {
            try
            {
                string json = File.ReadAllText("..//..//data.json");
                Data data = JsonSerializer.Deserialize<Data>(json);
                this.userSV = data.TKUserSV;
                this.dssv = data.DanhSachSinhVien;
                this.dsmh = data.DanhSachMonHoc;
                if (userSV == null) userSV = new UserSV();

            }
            catch (Exception ex)
            {
                userSV = new UserSV();
            }
        }


            
        
    }
  
}
