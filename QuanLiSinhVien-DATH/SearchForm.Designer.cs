namespace QuanLiSinhVien_DATH
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.txtndTim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.dgvTim = new System.Windows.Forms.DataGridView();
            this.cBTim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btHienThi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtndTim
            // 
            this.txtndTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtndTim.Location = new System.Drawing.Point(300, 136);
            this.txtndTim.Name = "txtndTim";
            this.txtndTim.Size = new System.Drawing.Size(386, 28);
            this.txtndTim.TabIndex = 0;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim.Image")));
            this.btn_Tim.Location = new System.Drawing.Point(707, 136);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(70, 56);
            this.btn_Tim.TabIndex = 21;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // dgvTim
            // 
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTim.Location = new System.Drawing.Point(34, 272);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.RowHeadersWidth = 51;
            this.dgvTim.RowTemplate.Height = 24;
            this.dgvTim.Size = new System.Drawing.Size(973, 304);
            this.dgvTim.TabIndex = 22;
            // 
            // cBTim
            // 
            this.cBTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cBTim.FormattingEnabled = true;
            this.cBTim.Items.AddRange(new object[] {
            "Mã SV",
            "Họ Tên",
            "Email",
            "Ngày Sinh",
            "Giới Tính",
            "Số Điện Thoại",
            "Địa Chỉ"});
            this.cBTim.Location = new System.Drawing.Point(300, 186);
            this.cBTim.Name = "cBTim";
            this.cBTim.Size = new System.Drawing.Size(121, 28);
            this.cBTim.TabIndex = 23;
            this.cBTim.Text = "Mã SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(109, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nội Dung Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(109, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cột Tim Kiếm";
            // 
            // btHienThi
            // 
            this.btHienThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHienThi.Location = new System.Drawing.Point(820, 133);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(118, 61);
            this.btHienThi.TabIndex = 26;
            this.btHienThi.Text = "Hiển Thị Toàn Bộ Dữ Liệu";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(418, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 51);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tìm Kiếm";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1041, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBTim);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txtndTim);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtndTim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.DataGridView dgvTim;
        private System.Windows.Forms.ComboBox cBTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Label label3;
    }
}