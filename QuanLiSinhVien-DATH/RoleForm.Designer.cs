namespace QuanLiSinhVien_DATH
{
    partial class RoleForm
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
            this.btn_GV = new System.Windows.Forms.Button();
            this.btn_SV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(84, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãy Chọn Vai Trò Của Bạn";
            // 
            // btn_GV
            // 
            this.btn_GV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_GV.Location = new System.Drawing.Point(65, 109);
            this.btn_GV.Name = "btn_GV";
            this.btn_GV.Size = new System.Drawing.Size(111, 89);
            this.btn_GV.TabIndex = 1;
            this.btn_GV.Text = "Giáo Viên";
            this.btn_GV.UseVisualStyleBackColor = true;
            this.btn_GV.Click += new System.EventHandler(this.btn_GV_Click);
            // 
            // btn_SV
            // 
            this.btn_SV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SV.Location = new System.Drawing.Point(275, 109);
            this.btn_SV.Name = "btn_SV";
            this.btn_SV.Size = new System.Drawing.Size(111, 89);
            this.btn_SV.TabIndex = 2;
            this.btn_SV.Text = "Sinh Viên";
            this.btn_SV.UseVisualStyleBackColor = true;
            this.btn_SV.Click += new System.EventHandler(this.btn_SV_Click);
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 233);
            this.Controls.Add(this.btn_SV);
            this.Controls.Add(this.btn_GV);
            this.Controls.Add(this.label1);
            this.Name = "RoleForm";
            this.Text = "RoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GV;
        private System.Windows.Forms.Button btn_SV;
    }
}