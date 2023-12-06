namespace QuanLiSinhVien_DATH
{
    partial class TimKiemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemForm));
            this.label3 = new System.Windows.Forms.Label();
            this.btHienThi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBTim = new System.Windows.Forms.ComboBox();
            this.dgvTim = new System.Windows.Forms.DataGridView();
            this.txtndTim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(415, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 40);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tìm Kiếm";
            // 
            // btHienThi
            // 
            this.btHienThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHienThi.Location = new System.Drawing.Point(716, 59);
            this.btHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(104, 50);
            this.btHienThi.TabIndex = 34;
            this.btHienThi.Text = "Hiển Thị Toàn Bộ Dữ Liệu";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(183, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cột Tim Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(183, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nội Dung Tìm Kiếm";
            // 
            // cBTim
            // 
            this.cBTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cBTim.FormattingEnabled = true;
            this.cBTim.Items.AddRange(new object[] {
            "Mã SV",
            "Họ Tên",
            "Giới Tính",
            "Ngày Sinh",
            "Địa chỉ",
            "Email",
            "Dân Tộc",
            "Quốc Tịch",
            "Số DT",
            "Mã CN",
            "Tên CN"});
            this.cBTim.Location = new System.Drawing.Point(326, 102);
            this.cBTim.Margin = new System.Windows.Forms.Padding(2);
            this.cBTim.Name = "cBTim";
            this.cBTim.Size = new System.Drawing.Size(92, 24);
            this.cBTim.TabIndex = 31;
            this.cBTim.Text = "Mã SV";
            // 
            // dgvTim
            // 
            this.dgvTim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTim.Location = new System.Drawing.Point(11, 158);
            this.dgvTim.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.RowHeadersWidth = 51;
            this.dgvTim.RowTemplate.Height = 24;
            this.dgvTim.Size = new System.Drawing.Size(931, 247);
            this.dgvTim.TabIndex = 30;
            // 
            // txtndTim
            // 
            this.txtndTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtndTim.Location = new System.Drawing.Point(326, 61);
            this.txtndTim.Margin = new System.Windows.Forms.Padding(2);
            this.txtndTim.Name = "txtndTim";
            this.txtndTim.Size = new System.Drawing.Size(290, 24);
            this.txtndTim.TabIndex = 28;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim.Image")));
            this.btn_Tim.Location = new System.Drawing.Point(631, 61);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(52, 46);
            this.btn_Tim.TabIndex = 29;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // TimKiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBTim);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txtndTim);
            this.Name = "TimKiemForm";
            this.Text = "TimKiemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBTim;
        private System.Windows.Forms.DataGridView dgvTim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txtndTim;
    }
}