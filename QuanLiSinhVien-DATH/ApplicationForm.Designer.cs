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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
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
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoctich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtqt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdmsv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số ĐT";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(161, 48);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(107, 20);
            this.txtmasv.TabIndex = 8;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(161, 84);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(107, 20);
            this.txthoten.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(560, 88);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(107, 20);
            this.txtemail.TabIndex = 10;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(560, 51);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(107, 20);
            this.txtdiachi.TabIndex = 11;
            // 
            // radnam
            // 
            this.radnam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(152, 128);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(47, 17);
            this.radnam.TabIndex = 12;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(220, 130);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(39, 17);
            this.radnu.TabIndex = 13;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(343, 54);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(107, 20);
            this.dtpngaysinh.TabIndex = 14;
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(560, 123);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(107, 20);
            this.txtsodt.TabIndex = 15;
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(744, 60);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 33);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(744, 95);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(85, 33);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(744, 134);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(85, 36);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dgvdmsv
            // 
            this.dgvdmsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdmsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdmsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hoten,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.email,
            this.dantoc,
            this.quoctich,
            this.sodt});
            this.dgvdmsv.Location = new System.Drawing.Point(2, 214);
            this.dgvdmsv.Name = "dgvdmsv";
            this.dgvdmsv.ReadOnly = true;
            this.dgvdmsv.RowHeadersWidth = 51;
            this.dgvdmsv.Size = new System.Drawing.Size(935, 150);
            this.dgvdmsv.TabIndex = 19;
            this.dgvdmsv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdmsv_RowEnter);
            // 
            // masv
            // 
            this.masv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masv.DataPropertyName = "MaSV";
            this.masv.HeaderText = "Mã Sinh Viên";
            this.masv.Name = "masv";
            this.masv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "HoTen";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "GioiTinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh.DataPropertyName = "NgaySinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "Diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // dantoc
            // 
            this.dantoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dantoc.DataPropertyName = "Dantoc";
            this.dantoc.HeaderText = "Dân Tộc";
            this.dantoc.Name = "dantoc";
            this.dantoc.ReadOnly = true;
            // 
            // quoctich
            // 
            this.quoctich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quoctich.DataPropertyName = "Quoctich";
            this.quoctich.HeaderText = "Quốc Tịch";
            this.quoctich.Name = "quoctich";
            this.quoctich.ReadOnly = true;
            // 
            // sodt
            // 
            this.sodt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sodt.DataPropertyName = "Sodt";
            this.sodt.HeaderText = "Số ĐT";
            this.sodt.Name = "sodt";
            this.sodt.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Quốc Tịch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Dân Tộc";
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(343, 95);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(114, 20);
            this.txtdt.TabIndex = 26;
            // 
            // txtqt
            // 
            this.txtqt.Location = new System.Drawing.Point(343, 129);
            this.txtqt.Name = "txtqt";
            this.txtqt.Size = new System.Drawing.Size(114, 20);
            this.txtqt.TabIndex = 26;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(949, 365);
            this.Controls.Add(this.txtqt);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvdmsv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
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
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtqt;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoctich;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
    }
}