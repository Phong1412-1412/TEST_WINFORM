
namespace TEST_WINFORM
{
    partial class DanhSachKhachHang
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
            this.panel_ListKH = new System.Windows.Forms.Panel();
            this.listV_DSKH = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaNguoiThue = new System.Windows.Forms.TextBox();
            this.txt_TenNguoiThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.dtime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_XemPhongThue = new System.Windows.Forms.Button();
            this.btn_XoaNguoiThue = new System.Windows.Forms.Button();
            this.btn_SuaNguoiThue = new System.Windows.Forms.Button();
            this.btn_ThemNguoiThue = new System.Windows.Forms.Button();
            this.btn_QuyLai = new System.Windows.Forms.Button();
            this.panel_ListKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ListKH
            // 
            this.panel_ListKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_ListKH.Controls.Add(this.listV_DSKH);
            this.panel_ListKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ListKH.Location = new System.Drawing.Point(0, 288);
            this.panel_ListKH.Name = "panel_ListKH";
            this.panel_ListKH.Size = new System.Drawing.Size(944, 203);
            this.panel_ListKH.TabIndex = 0;
            // 
            // listV_DSKH
            // 
            this.listV_DSKH.AllowDrop = true;
            this.listV_DSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_DSKH.FullRowSelect = true;
            this.listV_DSKH.GridLines = true;
            this.listV_DSKH.HideSelection = false;
            this.listV_DSKH.Location = new System.Drawing.Point(0, 0);
            this.listV_DSKH.Name = "listV_DSKH";
            this.listV_DSKH.Size = new System.Drawing.Size(944, 203);
            this.listV_DSKH.TabIndex = 0;
            this.listV_DSKH.UseCompatibleStateImageBehavior = false;
            this.listV_DSKH.View = System.Windows.Forms.View.List;
            this.listV_DSKH.SelectedIndexChanged += new System.EventHandler(this.listV_DSKH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(811, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________________________________";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã người thuê:";
            // 
            // txt_MaNguoiThue
            // 
            this.txt_MaNguoiThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaNguoiThue.Enabled = false;
            this.txt_MaNguoiThue.Location = new System.Drawing.Point(128, 78);
            this.txt_MaNguoiThue.Name = "txt_MaNguoiThue";
            this.txt_MaNguoiThue.Size = new System.Drawing.Size(64, 20);
            this.txt_MaNguoiThue.TabIndex = 5;
            this.txt_MaNguoiThue.Text = "0";
            // 
            // txt_TenNguoiThue
            // 
            this.txt_TenNguoiThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenNguoiThue.Location = new System.Drawing.Point(128, 128);
            this.txt_TenNguoiThue.Name = "txt_TenNguoiThue";
            this.txt_TenNguoiThue.Size = new System.Drawing.Size(150, 20);
            this.txt_TenNguoiThue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên người thuê:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Location = new System.Drawing.Point(128, 179);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(150, 20);
            this.txt_SDT.TabIndex = 9;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại:";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CMND.Location = new System.Drawing.Point(414, 80);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(150, 20);
            this.txt_CMND.TabIndex = 11;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(300, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "CMND:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(300, 132);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(68, 16);
            this.lbl_GioiTinh.TabIndex = 12;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(300, 179);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(81, 16);
            this.lbl_NgaySinh.TabIndex = 14;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DiaChi.Location = new System.Drawing.Point(666, 78);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(265, 121);
            this.txt_DiaChi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(605, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Địa chỉ:";
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không biết"});
            this.cbb_GioiTinh.Location = new System.Drawing.Point(413, 129);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbb_GioiTinh.TabIndex = 23;
            // 
            // dtime_NgaySinh
            // 
            this.dtime_NgaySinh.Location = new System.Drawing.Point(413, 181);
            this.dtime_NgaySinh.Name = "dtime_NgaySinh";
            this.dtime_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtime_NgaySinh.TabIndex = 29;
            // 
            // btn_XemPhongThue
            // 
            this.btn_XemPhongThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemPhongThue.AutoSize = true;
            this.btn_XemPhongThue.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_XemPhongThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemPhongThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemPhongThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_XemPhongThue.Image = global::TEST_WINFORM.Properties.Resources.see;
            this.btn_XemPhongThue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemPhongThue.Location = new System.Drawing.Point(427, 250);
            this.btn_XemPhongThue.Name = "btn_XemPhongThue";
            this.btn_XemPhongThue.Size = new System.Drawing.Size(138, 32);
            this.btn_XemPhongThue.TabIndex = 21;
            this.btn_XemPhongThue.Text = "Xem phòng thuê";
            this.btn_XemPhongThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XemPhongThue.UseVisualStyleBackColor = false;
            this.btn_XemPhongThue.Click += new System.EventHandler(this.btn_XemPhongThue_Click);
            // 
            // btn_XoaNguoiThue
            // 
            this.btn_XoaNguoiThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XoaNguoiThue.AutoSize = true;
            this.btn_XoaNguoiThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaNguoiThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNguoiThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_XoaNguoiThue.Image = global::TEST_WINFORM.Properties.Resources.delete;
            this.btn_XoaNguoiThue.Location = new System.Drawing.Point(850, 250);
            this.btn_XoaNguoiThue.Name = "btn_XoaNguoiThue";
            this.btn_XoaNguoiThue.Size = new System.Drawing.Size(81, 32);
            this.btn_XoaNguoiThue.TabIndex = 20;
            this.btn_XoaNguoiThue.Text = "Xóa";
            this.btn_XoaNguoiThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaNguoiThue.UseVisualStyleBackColor = false;
            this.btn_XoaNguoiThue.Click += new System.EventHandler(this.btn_XoaNguoiThue_Click);
            // 
            // btn_SuaNguoiThue
            // 
            this.btn_SuaNguoiThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SuaNguoiThue.AutoSize = true;
            this.btn_SuaNguoiThue.BackColor = System.Drawing.Color.Green;
            this.btn_SuaNguoiThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNguoiThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SuaNguoiThue.Image = global::TEST_WINFORM.Properties.Resources.edit;
            this.btn_SuaNguoiThue.Location = new System.Drawing.Point(736, 250);
            this.btn_SuaNguoiThue.Name = "btn_SuaNguoiThue";
            this.btn_SuaNguoiThue.Size = new System.Drawing.Size(99, 32);
            this.btn_SuaNguoiThue.TabIndex = 19;
            this.btn_SuaNguoiThue.Text = "Chỉnh sửa";
            this.btn_SuaNguoiThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SuaNguoiThue.UseVisualStyleBackColor = false;
            this.btn_SuaNguoiThue.Click += new System.EventHandler(this.btn_SuaNguoiThue_Click);
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
            this.btn_ThemNguoiThue.Location = new System.Drawing.Point(583, 250);
            this.btn_ThemNguoiThue.Name = "btn_ThemNguoiThue";
            this.btn_ThemNguoiThue.Size = new System.Drawing.Size(138, 32);
            this.btn_ThemNguoiThue.TabIndex = 18;
            this.btn_ThemNguoiThue.Text = "Thêm người thuê";
            this.btn_ThemNguoiThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemNguoiThue.UseVisualStyleBackColor = false;
            this.btn_ThemNguoiThue.Click += new System.EventHandler(this.btn_ThemNguoiThue_Click);
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
            this.btn_QuyLai.Location = new System.Drawing.Point(806, 12);
            this.btn_QuyLai.Name = "btn_QuyLai";
            this.btn_QuyLai.Size = new System.Drawing.Size(126, 39);
            this.btn_QuyLai.TabIndex = 3;
            this.btn_QuyLai.Text = "Quay lại";
            this.btn_QuyLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuyLai.UseVisualStyleBackColor = false;
            this.btn_QuyLai.Click += new System.EventHandler(this.btn_QuyLai_Click);
            // 
            // DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 491);
            this.Controls.Add(this.dtime_NgaySinh);
            this.Controls.Add(this.cbb_GioiTinh);
            this.Controls.Add(this.btn_XemPhongThue);
            this.Controls.Add(this.btn_XoaNguoiThue);
            this.Controls.Add(this.btn_SuaNguoiThue);
            this.Controls.Add(this.btn_ThemNguoiThue);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenNguoiThue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MaNguoiThue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_QuyLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_ListKH);
            this.Name = "DanhSachKhachHang";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DanhSachKhachHang_Load);
            this.panel_ListKH.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ListKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_QuyLai;
        private System.Windows.Forms.ListView listV_DSKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNguoiThue;
        private System.Windows.Forms.TextBox txt_TenNguoiThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_XoaNguoiThue;
        private System.Windows.Forms.Button btn_SuaNguoiThue;
        private System.Windows.Forms.Button btn_ThemNguoiThue;
        private System.Windows.Forms.Button btn_XemPhongThue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.DateTimePicker dtime_NgaySinh;
    }
}