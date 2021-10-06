
namespace TEST_WINFORM
{
    partial class ĐăngNhập
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
            this.txt_TenNguoiDung = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHÀO MỰNG BẠN ĐẾN VỚI QL_NT APP";
            // 
            // txt_TenNguoiDung
            // 
            this.txt_TenNguoiDung.Location = new System.Drawing.Point(136, 99);
            this.txt_TenNguoiDung.Name = "txt_TenNguoiDung";
            this.txt_TenNguoiDung.Size = new System.Drawing.Size(158, 20);
            this.txt_TenNguoiDung.TabIndex = 1;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DangNhap.Location = new System.Drawing.Point(270, 214);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(129, 28);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập ";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÊN NGƯỜI DÙNG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MẬT KHẨU:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(136, 148);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(158, 20);
            this.txt_MatKhau.TabIndex = 6;
            this.txt_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatKhau_KeyPress);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DangKy.Location = new System.Drawing.Point(15, 214);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(129, 28);
            this.btn_DangKy.TabIndex = 7;
            this.btn_DangKy.Text = "Chưa có tài khoản";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // ĐăngNhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TEST_WINFORM.Properties.Resources.backgr_DN;
            this.ClientSize = new System.Drawing.Size(411, 274);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_TenNguoiDung);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ĐăngNhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐăngNhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenNguoiDung;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangKy;
    }
}