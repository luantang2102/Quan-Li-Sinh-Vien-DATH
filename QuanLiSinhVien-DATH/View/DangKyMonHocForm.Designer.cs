namespace QuanLiSinhVien_DATH
{
    partial class DangKyMonHocForm
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
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.lb_mh = new System.Windows.Forms.CheckedListBox();
            this.dgvdkmh = new System.Windows.Forms.DataGridView();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdkmh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmssv
            // 
            this.txtmssv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmssv.Location = new System.Drawing.Point(67, 6);
            this.txtmssv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.ReadOnly = true;
            this.txtmssv.Size = new System.Drawing.Size(127, 15);
            this.txtmssv.TabIndex = 0;
            // 
            // lb_mh
            // 
            this.lb_mh.CheckOnClick = true;
            this.lb_mh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_mh.FormattingEnabled = true;
            this.lb_mh.Location = new System.Drawing.Point(243, 50);
            this.lb_mh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_mh.Name = "lb_mh";
            this.lb_mh.Size = new System.Drawing.Size(707, 154);
            this.lb_mh.TabIndex = 1;
            this.lb_mh.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lb_mh_ItemCheck);
            // 
            // dgvdkmh
            // 
            this.dgvdkmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdkmh.Location = new System.Drawing.Point(243, 244);
            this.dgvdkmh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdkmh.Name = "dgvdkmh";
            this.dgvdkmh.RowHeadersWidth = 51;
            this.dgvdkmh.RowTemplate.Height = 24;
            this.dgvdkmh.Size = new System.Drawing.Size(711, 263);
            this.dgvdkmh.TabIndex = 2;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(67, 347);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(92, 65);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Visible = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "MSSV:";
            // 
            // btn_hien
            // 
            this.btn_hien.Location = new System.Drawing.Point(67, 246);
            this.btn_hien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hien.Name = "btn_hien";
            this.btn_hien.Size = new System.Drawing.Size(92, 65);
            this.btn_hien.TabIndex = 5;
            this.btn_hien.Text = "Xem Thông Tin Môn Học Đã Chọn";
            this.btn_hien.UseVisualStyleBackColor = true;
            this.btn_hien.Click += new System.EventHandler(this.btn_hien_Click);
            // 
            // DangKyMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(965, 519);
            this.Controls.Add(this.btn_hien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.dgvdkmh);
            this.Controls.Add(this.lb_mh);
            this.Controls.Add(this.txtmssv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangKyMonHocForm";
            this.Text = "DKMH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangKyMonHocForm_FormClosed);
            this.Load += new System.EventHandler(this.DKMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdkmh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.CheckedListBox lb_mh;
        private System.Windows.Forms.DataGridView dgvdkmh;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hien;
    }
}