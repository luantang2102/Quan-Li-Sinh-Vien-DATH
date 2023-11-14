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
    public partial class UserForm : Form
    {
        List<User> userList;
        
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            //Read file users 
            //TO DO
            //.
            //.
            userList = new List<User>();

            //Test login func
            User user = new User("luan", "123");
            userList.Add(user);
            //----------------------------------
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
            if (userList.Any() != true)
            {
                MessageBox.Show("Chưa có tài khoản trong cơ sở dữ liệu");
                return;
            }
            foreach (User user in userList)
            {
                if (user.getUsername().Equals(usernameTB.Text) && user.getPassword().Equals(passwordTB.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    ApplicationForm applicationForm = new ApplicationForm(user);
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
            foreach(User user in userList)
            {
                if(user.getUsername().Equals(usernameRTB.Text))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }
            }
            if(password1RTB.Text.Equals(password2RTB.Text))
            {
                User user = new User();
                user.setUsername(usernameRTB.Text);
                user.setPassword(password2RTB.Text);

                userList.Add(user);

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

        private void signInPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
