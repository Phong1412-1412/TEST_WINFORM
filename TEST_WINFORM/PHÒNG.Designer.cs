
namespace TEST_WINFORM
{
    partial class Phong
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
            this.panel_DSPhong = new System.Windows.Forms.Panel();
            this.lbl_PhongDangChoThue = new System.Windows.Forms.Label();
            this.lbl_PhongTrong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XoaNha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_NhaTro = new System.Windows.Forms.ComboBox();
            this.lbl_TinhTrangPhongTheoNhaTro = new System.Windows.Forms.Label();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.btn_ThemPhongNhanh = new System.Windows.Forms.Button();
            this.lbl_CountPhong = new System.Windows.Forms.Label();
            this.btn_ThemNha = new System.Windows.Forms.Button();
            this.btn_Phong = new System.Windows.Forms.Button();
            this.btn_NguoiThue = new System.Windows.Forms.Button();
            this.lbl_TongPhong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbb_TrangThaiPhieuThuTien = new System.Windows.Forms.ComboBox();
            this.cbb_TrangThaiPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_PhongChiTiet = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.panel_DSPhong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DSPhong
            // 
            this.panel_DSPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_DSPhong.Controls.Add(this.lbl_PhongDangChoThue);
            this.panel_DSPhong.Controls.Add(this.lbl_PhongTrong);
            this.panel_DSPhong.Controls.Add(this.groupBox1);
            this.panel_DSPhong.Controls.Add(this.lbl_CountPhong);
            this.panel_DSPhong.Controls.Add(this.btn_ThemNha);
            this.panel_DSPhong.Controls.Add(this.btn_Phong);
            this.panel_DSPhong.Controls.Add(this.btn_NguoiThue);
            this.panel_DSPhong.Controls.Add(this.lbl_TongPhong);
            this.panel_DSPhong.Controls.Add(this.btn_TimKiem);
            this.panel_DSPhong.Controls.Add(this.textBox1);
            this.panel_DSPhong.Controls.Add(this.cbb_TrangThaiPhieuThuTien);
            this.panel_DSPhong.Controls.Add(this.cbb_TrangThaiPhong);
            this.panel_DSPhong.Controls.Add(this.label1);
            this.panel_DSPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DSPhong.Location = new System.Drawing.Point(0, 0);
            this.panel_DSPhong.Name = "panel_DSPhong";
            this.panel_DSPhong.Size = new System.Drawing.Size(927, 173);
            this.panel_DSPhong.TabIndex = 0;
            this.panel_DSPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DSPhong_Paint);
            // 
            // lbl_PhongDangChoThue
            // 
            this.lbl_PhongDangChoThue.AutoSize = true;
            this.lbl_PhongDangChoThue.Location = new System.Drawing.Point(214, 60);
            this.lbl_PhongDangChoThue.Name = "lbl_PhongDangChoThue";
            this.lbl_PhongDangChoThue.Size = new System.Drawing.Size(124, 13);
            this.lbl_PhongDangChoThue.TabIndex = 15;
            this.lbl_PhongDangChoThue.Text = "|| Phòng đang cho thuê: ";
            // 
            // lbl_PhongTrong
            // 
            this.lbl_PhongTrong.AutoSize = true;
            this.lbl_PhongTrong.Location = new System.Drawing.Point(118, 60);
            this.lbl_PhongTrong.Name = "lbl_PhongTrong";
            this.lbl_PhongTrong.Size = new System.Drawing.Size(75, 13);
            this.lbl_PhongTrong.TabIndex = 14;
            this.lbl_PhongTrong.Text = "|| Phòng trống:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_XoaNha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_NhaTro);
            this.groupBox1.Controls.Add(this.lbl_TinhTrangPhongTheoNhaTro);
            this.groupBox1.Controls.Add(this.btn_ThemPhong);
            this.groupBox1.Controls.Add(this.btn_ThemPhongNhanh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 79);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btn_XoaNha
            // 
            this.btn_XoaNha.AutoSize = true;
            this.btn_XoaNha.BackColor = System.Drawing.Color.Red;
            this.btn_XoaNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNha.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_XoaNha.Location = new System.Drawing.Point(591, 48);
            this.btn_XoaNha.Name = "btn_XoaNha";
            this.btn_XoaNha.Size = new System.Drawing.Size(89, 25);
            this.btn_XoaNha.TabIndex = 16;
            this.btn_XoaNha.Text = "Xóa nhà";
            this.btn_XoaNha.UseVisualStyleBackColor = false;
            this.btn_XoaNha.Click += new System.EventHandler(this.btn_XoaNha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhà trọ";
            // 
            // cbb_NhaTro
            // 
            this.cbb_NhaTro.FormattingEnabled = true;
            this.cbb_NhaTro.Items.AddRange(new object[] {
            "Hiển thị tất cả"});
            this.cbb_NhaTro.Location = new System.Drawing.Point(73, 16);
            this.cbb_NhaTro.Name = "cbb_NhaTro";
            this.cbb_NhaTro.Size = new System.Drawing.Size(134, 21);
            this.cbb_NhaTro.TabIndex = 17;
            this.cbb_NhaTro.SelectedIndexChanged += new System.EventHandler(this.cbb_NhaTro_SelectedIndexChanged);
            // 
            // lbl_TinhTrangPhongTheoNhaTro
            // 
            this.lbl_TinhTrangPhongTheoNhaTro.AutoSize = true;
            this.lbl_TinhTrangPhongTheoNhaTro.Location = new System.Drawing.Point(14, 54);
            this.lbl_TinhTrangPhongTheoNhaTro.Name = "lbl_TinhTrangPhongTheoNhaTro";
            this.lbl_TinhTrangPhongTheoNhaTro.Size = new System.Drawing.Size(202, 13);
            this.lbl_TinhTrangPhongTheoNhaTro.TabIndex = 13;
            this.lbl_TinhTrangPhongTheoNhaTro.Text = "Còn trống:  || Đã xho thuê:  || còn nợ tiền: ";
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.AutoSize = true;
            this.btn_ThemPhong.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemPhong.Location = new System.Drawing.Point(820, 48);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(89, 25);
            this.btn_ThemPhong.TabIndex = 13;
            this.btn_ThemPhong.Text = "Thêm phòng";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // btn_ThemPhongNhanh
            // 
            this.btn_ThemPhongNhanh.AutoSize = true;
            this.btn_ThemPhongNhanh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ThemPhongNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemPhongNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPhongNhanh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemPhongNhanh.Location = new System.Drawing.Point(686, 48);
            this.btn_ThemPhongNhanh.Name = "btn_ThemPhongNhanh";
            this.btn_ThemPhongNhanh.Size = new System.Drawing.Size(128, 25);
            this.btn_ThemPhongNhanh.TabIndex = 12;
            this.btn_ThemPhongNhanh.Text = "Thêm phòng nhanh";
            this.btn_ThemPhongNhanh.UseVisualStyleBackColor = false;
            // 
            // lbl_CountPhong
            // 
            this.lbl_CountPhong.AutoSize = true;
            this.lbl_CountPhong.Location = new System.Drawing.Point(790, 9);
            this.lbl_CountPhong.Name = "lbl_CountPhong";
            this.lbl_CountPhong.Size = new System.Drawing.Size(0, 13);
            this.lbl_CountPhong.TabIndex = 13;
            this.lbl_CountPhong.Visible = false;
            // 
            // btn_ThemNha
            // 
            this.btn_ThemNha.AutoSize = true;
            this.btn_ThemNha.BackColor = System.Drawing.Color.Green;
            this.btn_ThemNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemNha.Location = new System.Drawing.Point(820, 66);
            this.btn_ThemNha.Name = "btn_ThemNha";
            this.btn_ThemNha.Size = new System.Drawing.Size(89, 25);
            this.btn_ThemNha.TabIndex = 12;
            this.btn_ThemNha.Text = "Thêm nhà";
            this.btn_ThemNha.UseVisualStyleBackColor = false;
            this.btn_ThemNha.Click += new System.EventHandler(this.btn_ThemNha_Click);
            // 
            // btn_Phong
            // 
            this.btn_Phong.AutoSize = true;
            this.btn_Phong.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Phong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Phong.Location = new System.Drawing.Point(754, 66);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(63, 25);
            this.btn_Phong.TabIndex = 11;
            this.btn_Phong.Text = "Phòng";
            this.btn_Phong.UseVisualStyleBackColor = false;
            this.btn_Phong.Click += new System.EventHandler(this.btn_Phong_Click);
            // 
            // btn_NguoiThue
            // 
            this.btn_NguoiThue.AutoSize = true;
            this.btn_NguoiThue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_NguoiThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NguoiThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_NguoiThue.Location = new System.Drawing.Point(669, 66);
            this.btn_NguoiThue.Name = "btn_NguoiThue";
            this.btn_NguoiThue.Size = new System.Drawing.Size(81, 25);
            this.btn_NguoiThue.TabIndex = 10;
            this.btn_NguoiThue.Text = "Người thuê";
            this.btn_NguoiThue.UseVisualStyleBackColor = false;
            this.btn_NguoiThue.Click += new System.EventHandler(this.btn_NguoiThue_Click);
            // 
            // lbl_TongPhong
            // 
            this.lbl_TongPhong.AutoSize = true;
            this.lbl_TongPhong.Location = new System.Drawing.Point(23, 60);
            this.lbl_TongPhong.Name = "lbl_TongPhong";
            this.lbl_TongPhong.Size = new System.Drawing.Size(71, 13);
            this.lbl_TongPhong.TabIndex = 9;
            this.lbl_TongPhong.Text = "Tổng phong: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Tìm kiếm";
            // 
            // cbb_TrangThaiPhieuThuTien
            // 
            this.cbb_TrangThaiPhieuThuTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_TrangThaiPhieuThuTien.FormattingEnabled = true;
            this.cbb_TrangThaiPhieuThuTien.Items.AddRange(new object[] {
            "1. Hiển thị phòng đã đóng tiền phòng",
            "2. Hiển thị phòng chưa đóng tiền"});
            this.cbb_TrangThaiPhieuThuTien.Location = new System.Drawing.Point(192, 25);
            this.cbb_TrangThaiPhieuThuTien.Name = "cbb_TrangThaiPhieuThuTien";
            this.cbb_TrangThaiPhieuThuTien.Size = new System.Drawing.Size(162, 21);
            this.cbb_TrangThaiPhieuThuTien.TabIndex = 2;
            this.cbb_TrangThaiPhieuThuTien.Text = "- Trạng thái phiếu thu tiền";
            this.cbb_TrangThaiPhieuThuTien.SelectedIndexChanged += new System.EventHandler(this.cbb_TrangThaiPhieuThuTien_SelectedIndexChanged);
            // 
            // cbb_TrangThaiPhong
            // 
            this.cbb_TrangThaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_TrangThaiPhong.FormattingEnabled = true;
            this.cbb_TrangThaiPhong.Items.AddRange(new object[] {
            "1. Hiện thị phòng đang cho thuê",
            "2 . Hiển thị phòng trống",
            "3. Hiển thị tất cả phòng"});
            this.cbb_TrangThaiPhong.Location = new System.Drawing.Point(12, 25);
            this.cbb_TrangThaiPhong.Name = "cbb_TrangThaiPhong";
            this.cbb_TrangThaiPhong.Size = new System.Drawing.Size(157, 21);
            this.cbb_TrangThaiPhong.TabIndex = 1;
            this.cbb_TrangThaiPhong.Text = "- Trạng thái phòng -";
            this.cbb_TrangThaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbb_TrangThaiPhong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phòng";
            // 
            // panel_PhongChiTiet
            // 
            this.panel_PhongChiTiet.AutoScroll = true;
            this.panel_PhongChiTiet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_PhongChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PhongChiTiet.Location = new System.Drawing.Point(0, 0);
            this.panel_PhongChiTiet.Name = "panel_PhongChiTiet";
            this.panel_PhongChiTiet.Size = new System.Drawing.Size(927, 465);
            this.panel_PhongChiTiet.TabIndex = 3;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TimKiem.Image = global::TEST_WINFORM.Properties.Resources._17853935111558096454_16;
            this.btn_TimKiem.Location = new System.Drawing.Point(542, 20);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(99, 31);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(927, 465);
            this.Controls.Add(this.panel_DSPhong);
            this.Controls.Add(this.panel_PhongChiTiet);
            this.Name = "Phong";
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.panel_DSPhong.ResumeLayout(false);
            this.panel_DSPhong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_DSPhong;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbb_TrangThaiPhieuThuTien;
        private System.Windows.Forms.ComboBox cbb_TrangThaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThemNha;
        private System.Windows.Forms.Button btn_Phong;
        private System.Windows.Forms.Button btn_NguoiThue;
        private System.Windows.Forms.Label lbl_TongPhong;
        private System.Windows.Forms.Panel panel_PhongChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ThemPhong;
        private System.Windows.Forms.Button btn_ThemPhongNhanh;
        private System.Windows.Forms.Label lbl_TinhTrangPhongTheoNhaTro;
        private System.Windows.Forms.Label lbl_CountPhong;
        private System.Windows.Forms.Label lbl_PhongDangChoThue;
        private System.Windows.Forms.Label lbl_PhongTrong;
        private System.Windows.Forms.ComboBox cbb_NhaTro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XoaNha;
    }
}