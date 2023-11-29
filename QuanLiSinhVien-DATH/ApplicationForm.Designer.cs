namespace QuanLiSinhVien_DATH
{
    partial class ApplicationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dgvdmsv = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbTim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdmsv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(426, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số ĐT";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(150, 71);
            this.txtmasv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(148, 26);
            this.txtmasv.TabIndex = 8;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(150, 126);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(148, 26);
            this.txthoten.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(150, 178);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 26);
            this.txtemail.TabIndex = 10;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(150, 248);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(148, 26);
            this.txtdiachi.TabIndex = 11;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(522, 68);
            this.radnam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(67, 24);
            this.radnam.TabIndex = 12;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(522, 105);
            this.radnu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(54, 24);
            this.radnu.TabIndex = 13;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(522, 155);
            this.dtpngaysinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(212, 26);
            this.dtpngaysinh.TabIndex = 14;
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(522, 221);
            this.txtsodt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(148, 26);
            this.txtsodt.TabIndex = 15;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(1130, 68);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 35);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(1130, 120);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 35);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(1130, 171);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 35);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // dgvdmsv
            // 
            this.dgvdmsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdmsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hoten,
            this.email,
            this.diachi,
            this.gioitinh,
            this.ngaysinh,
            this.sodt});
            this.dgvdmsv.Location = new System.Drawing.Point(3, 329);
            this.dgvdmsv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvdmsv.Name = "dgvdmsv";
            this.dgvdmsv.RowHeadersWidth = 51;
            this.dgvdmsv.Size = new System.Drawing.Size(1304, 231);
            this.dgvdmsv.TabIndex = 19;
            this.dgvdmsv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdmsv_RowEnter);
            // 
            // masv
            // 
            this.masv.DataPropertyName = "MaSV";
            this.masv.HeaderText = "Mã Sinh Vien";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "HoTen";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "Diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "GioiTinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaySinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // sodt
            // 
            this.sodt.DataPropertyName = "Sodt";
            this.sodt.HeaderText = "Số ĐT";
            this.sodt.MinimumWidth = 6;
            this.sodt.Name = "sodt";
            this.sodt.Width = 125;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(1130, 225);
            this.btTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(112, 35);
            this.btTim.TabIndex = 20;
            this.btTim.Text = "Tim";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(811, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cột Cần Tìm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(811, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nội Dung";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(918, 238);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(148, 26);
            this.txtTim.TabIndex = 23;
            // 
            // cbTim
            // 
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Họ tên",
            "Email",
            "",
            "Giới Tính ",
            "SĐT",
            "Địa Chỉ"});
            this.cbTim.Location = new System.Drawing.Point(918, 194);
            this.cbTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(180, 28);
            this.cbTim.TabIndex = 24;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 562);
            this.Controls.Add(this.cbTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.dgvdmsv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsodt);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApplicationForm";
            this.Text = "ApplicatioForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicationForm_FormClosed);
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdmsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dgvdmsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbTim;
    }
}