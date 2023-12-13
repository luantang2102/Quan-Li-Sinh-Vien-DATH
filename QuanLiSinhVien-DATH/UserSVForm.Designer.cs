namespace QuanLiSinhVien_DATH
{
    partial class UserSVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signInPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.signInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInPanel
            // 
            this.signInPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.signInPanel.Controls.Add(this.label2);
            this.signInPanel.Controls.Add(this.label4);
            this.signInPanel.Controls.Add(this.label9);
            this.signInPanel.Controls.Add(this.label8);
            this.signInPanel.Controls.Add(this.label1);
            this.signInPanel.Controls.Add(this.passwordTB);
            this.signInPanel.Controls.Add(this.usernameTB);
            this.signInPanel.Controls.Add(this.loginBtn);
            this.signInPanel.Location = new System.Drawing.Point(88, 1);
            this.signInPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(376, 365);
            this.signInPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đăng Nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mật khẩu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên tài khoản :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài Khoản là: MSSV";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(100, 164);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(173, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(100, 126);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(173, 20);
            this.usernameTB.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginBtn.Location = new System.Drawing.Point(100, 197);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(172, 52);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "ĐĂNG NHẬP";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật Khẩu là: 123";
            // 
            // UserSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 366);
            this.Controls.Add(this.signInPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserSVForm";
            this.Text = "SinhVien";
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signInPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
    }
}