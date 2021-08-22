
namespace TEST_WINFORM
{
    partial class ThemNguoiThue
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
            this.btn_QuyLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenNguoiThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_XacNhanThemNT = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btn_QuyLai.Location = new System.Drawing.Point(309, 12);
            this.btn_QuyLai.Name = "btn_QuyLai";
            this.btn_QuyLai.Size = new System.Drawing.Size(126, 39);
            this.btn_QuyLai.TabIndex = 4;
            this.btn_QuyLai.Text = "Quay lại";
            this.btn_QuyLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuyLai.UseVisualStyleBackColor = false;
            this.btn_QuyLai.Click += new System.EventHandler(this.btn_QuyLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÊM MỚI NGƯỜI THUÊ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "_____________________________________________________________________";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Location = new System.Drawing.Point(125, 135);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(150, 20);
            this.txt_SDT.TabIndex = 15;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số điện thoại:";
            // 
            // txt_TenNguoiThue
            // 
            this.txt_TenNguoiThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenNguoiThue.Location = new System.Drawing.Point(125, 84);
            this.txt_TenNguoiThue.Name = "txt_TenNguoiThue";
            this.txt_TenNguoiThue.Size = new System.Drawing.Size(150, 20);
            this.txt_TenNguoiThue.TabIndex = 13;
            this.txt_TenNguoiThue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenNguoiThue_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên người thuê:";
            // 
            // dtime_NgaySinh
            // 
            this.dtime_NgaySinh.Location = new System.Drawing.Point(125, 272);
            this.dtime_NgaySinh.Name = "dtime_NgaySinh";
            this.dtime_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtime_NgaySinh.TabIndex = 28;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(11, 276);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(81, 16);
            this.lbl_NgaySinh.TabIndex = 27;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GioiTinh.Location = new System.Drawing.Point(125, 227);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(64, 20);
            this.txt_GioiTinh.TabIndex = 26;
            this.txt_GioiTinh.Text = "0";
            this.txt_GioiTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GioiTinh_KeyPress);
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(11, 229);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(68, 16);
            this.lbl_GioiTinh.TabIndex = 25;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CMND.Location = new System.Drawing.Point(125, 177);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(150, 20);
            this.txt_CMND.TabIndex = 24;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(11, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "CMND:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DiaChi.Location = new System.Drawing.Point(125, 312);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(300, 71);
            this.txt_DiaChi.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(12, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Địa chỉ:";
            // 
            // btn_XacNhanThemNT
            // 
            this.btn_XacNhanThemNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XacNhanThemNT.AutoSize = true;
            this.btn_XacNhanThemNT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_XacNhanThemNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhanThemNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhanThemNT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_XacNhanThemNT.Image = global::TEST_WINFORM.Properties.Resources.add;
            this.btn_XacNhanThemNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XacNhanThemNT.Location = new System.Drawing.Point(15, 435);
            this.btn_XacNhanThemNT.Name = "btn_XacNhanThemNT";
            this.btn_XacNhanThemNT.Size = new System.Drawing.Size(138, 32);
            this.btn_XacNhanThemNT.TabIndex = 31;
            this.btn_XacNhanThemNT.Text = "Xác nhận";
            this.btn_XacNhanThemNT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XacNhanThemNT.UseVisualStyleBackColor = false;
            this.btn_XacNhanThemNT.Click += new System.EventHandler(this.btn_XacNhanThemNT_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoMoi.AutoSize = true;
            this.btn_TaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TaoMoi.Image = global::TEST_WINFORM.Properties.Resources.delete;
            this.btn_TaoMoi.Location = new System.Drawing.Point(337, 435);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(88, 32);
            this.btn_TaoMoi.TabIndex = 32;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoMoi.UseVisualStyleBackColor = false;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(195, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "\"1 = Nam || 2 = Nữ || 3 = Không biết\"";
            // 
            // ThemNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.btn_XacNhanThemNT);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtime_NgaySinh);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.txt_GioiTinh);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenNguoiThue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_QuyLai);
            this.Name = "ThemNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguoiThue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QuyLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenNguoiThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtime_NgaySinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_XacNhanThemNT;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Label label3;
    }
}