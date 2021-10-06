
namespace TEST_WINFORM
{
    partial class Đăng_Ký_Chủ_Trọ
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QuyLai = new System.Windows.Forms.Button();
            this.btn_ThemNguoiThue = new System.Windows.Forms.Button();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenNguoiDung = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(607, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng ký tài khoản";
            // 
            // btn_QuyLai
            // 
            this.btn_QuyLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuyLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_QuyLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_QuyLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuyLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_QuyLai.Image = global::TEST_WINFORM.Properties.Resources.back24x24;
            this.btn_QuyLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuyLai.Location = new System.Drawing.Point(529, 12);
            this.btn_QuyLai.Name = "btn_QuyLai";
            this.btn_QuyLai.Size = new System.Drawing.Size(126, 39);
            this.btn_QuyLai.TabIndex = 5;
            this.btn_QuyLai.Text = "Quay lại";
            this.btn_QuyLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuyLai.UseVisualStyleBackColor = false;
            this.btn_QuyLai.Click += new System.EventHandler(this.btn_QuyLai_Click);
            // 
            // btn_ThemNguoiThue
            // 
            this.btn_ThemNguoiThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemNguoiThue.AutoSize = true;
            this.btn_ThemNguoiThue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ThemNguoiThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNguoiThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemNguoiThue.Image = global::TEST_WINFORM.Properties.Resources.add;
            this.btn_ThemNguoiThue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemNguoiThue.Location = new System.Drawing.Point(517, 219);
            this.btn_ThemNguoiThue.Name = "btn_ThemNguoiThue";
            this.btn_ThemNguoiThue.Size = new System.Drawing.Size(138, 32);
            this.btn_ThemNguoiThue.TabIndex = 19;
            this.btn_ThemNguoiThue.Text = "Thêm người thuê";
            this.btn_ThemNguoiThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemNguoiThue.UseVisualStyleBackColor = false;
            this.btn_ThemNguoiThue.Click += new System.EventHandler(this.btn_ThemNguoiThue_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DiaChi.Location = new System.Drawing.Point(390, 82);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(265, 121);
            this.txt_DiaChi.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(316, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Địa chỉ:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(140, 131);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(158, 20);
            this.txt_MatKhau.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "MẬT KHẨU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "TÊN NGƯỜI DÙNG:";
            // 
            // txt_TenNguoiDung
            // 
            this.txt_TenNguoiDung.Location = new System.Drawing.Point(140, 82);
            this.txt_TenNguoiDung.Name = "txt_TenNguoiDung";
            this.txt_TenNguoiDung.Size = new System.Drawing.Size(158, 20);
            this.txt_TenNguoiDung.TabIndex = 32;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(140, 183);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.PasswordChar = '*';
            this.txt_CMND.Size = new System.Drawing.Size(158, 20);
            this.txt_CMND.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "CMND/CCCD:";
            // 
            // Đăng_Ký_Chủ_Trọ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 263);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenNguoiDung);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_ThemNguoiThue);
            this.Controls.Add(this.btn_QuyLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Đăng_Ký_Chủ_Trọ";
            this.Text = "Đăng_Ký_Chủ_Trọ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QuyLai;
        private System.Windows.Forms.Button btn_ThemNguoiThue;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenNguoiDung;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label5;
    }
}