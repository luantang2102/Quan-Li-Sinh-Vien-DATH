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
    public partial class UserForm : Form
    {
        DSGV dsGV;
        Data saveData = new Data();

        private void docFile()
        {
            try
            {
                string json = File.ReadAllText("data.json");
                Data data = JsonSerializer.Deserialize<Data>(json);
                this.dsGV = data.DanhSachGiaoVien; 
                if(dsGV == null) dsGV = new DSGV();

            }
            catch (Exception ex)
            {
                dsGV = new DSGV();
            }
        }

        public UserForm()
        {
            InitializeComponent();
        }
           
        private void UserForm_Load(object sender, EventArgs e)
        { 
            docFile();
        }

        private void signUpSwitchBtn_Click(object sender, EventArgs e)
        {
            signInPanel.Visible = false;
            signUpPanel.Visible = true;
        }

        private void signInSwitchBtn_Click(object sender, EventArgs e)
        {
            signInPanel.Visible = true;
            signUpPanel.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (dsGV.DSgiaovien.Any() != true)
            {
                MessageBox.Show("Chưa có tài khoản trong cơ sở dữ liệu");
                return;
            }
            saveData.DanhSachGiaoVien = this.dsGV;
            foreach (User user in dsGV.DSgiaovien)
            {
                if (user.Username.Equals(usernameTB.Text) && user.Password.Equals(passwordTB.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    
                    this.Hide();
                    ApplicationForm applicationForm = new ApplicationForm(user, saveData);
                    applicationForm.ShowDialog();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            foreach(User user in dsGV.DSgiaovien)
            {
                if(user.Username.Equals(usernameRTB.Text))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }
            }
            if(password1RTB.Text.Equals(password2RTB.Text))
            {
                User user = new User();
                user.Username= usernameRTB.Text;
                user.Password= password2RTB.Text;

                dsGV.DSgiaovien.Add(user);

                MessageBox.Show("Dang ky thanh cong");
                signInPanel.Visible = true;
                signUpPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                password1RTB.Text = "";
                password2RTB.Text = "";
            }
        }
    }
}
