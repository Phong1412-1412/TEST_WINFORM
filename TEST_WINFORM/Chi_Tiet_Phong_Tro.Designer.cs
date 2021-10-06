
namespace TEST_WINFORM
{
    partial class Chi_Tiet_Phong_Tro
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
            this.lbl_MaPhongCT = new System.Windows.Forms.Label();
            this.txt_MaNhaTro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DS_PhieuThiTien = new System.Windows.Forms.DataGridView();
            this.lbl_CTPTTP_MP = new System.Windows.Forms.Label();
            this.grb_PhongChiTiet = new System.Windows.Forms.GroupBox();
            this.txt_TienNuoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TienPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TienDien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TienDatCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoTang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenNguoiThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ThangPT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TongTienPT = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txt_TienNuocPT = new System.Windows.Forms.TextBox();
            this.lbl_TienNuocPT = new System.Windows.Forms.Label();
            this.txt_TrangThaiPT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_TienPhongPT = new System.Windows.Forms.TextBox();
            this.lbl_TienPhongPT = new System.Windows.Forms.Label();
            this.txt_TienDienPT = new System.Windows.Forms.TextBox();
            this.lbl_TienDienPT = new System.Windows.Forms.Label();
            this.txt_MaHopDong = new System.Windows.Forms.TextBox();
            this.lbl_MaHopDong = new System.Windows.Forms.Label();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_InPT = new System.Windows.Forms.Button();
            this.btn_XemNguoiThue = new System.Windows.Forms.Button();
            this.btn_XoaPT = new System.Windows.Forms.Button();
            this.btn_ChinhPT = new System.Windows.Forms.Button();
            this.btn_ThemPT = new System.Windows.Forms.Button();
            this.btn_QuyLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_PhieuThiTien)).BeginInit();
            this.grb_PhongChiTiet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // lbl_MaPhongCT
            // 
            this.lbl_MaPhongCT.AutoSize = true;
            this.lbl_MaPhongCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaPhongCT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_MaPhongCT.Location = new System.Drawing.Point(12, 30);
            this.lbl_MaPhongCT.Name = "lbl_MaPhongCT";
            this.lbl_MaPhongCT.Size = new System.Drawing.Size(249, 24);
            this.lbl_MaPhongCT.TabIndex = 8;
            this.lbl_MaPhongCT.Text = "CHI TIẾT PHÒNG THUÊ: ";
            // 
            // txt_MaNhaTro
            // 
            this.txt_MaNhaTro.Location = new System.Drawing.Point(107, 31);
            this.txt_MaNhaTro.Name = "txt_MaNhaTro";
            this.txt_MaNhaTro.Size = new System.Drawing.Size(62, 22);
            this.txt_MaNhaTro.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(4, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mã nhà trọ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dgv_DS_PhieuThiTien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 145);
            this.panel1.TabIndex = 28;
            // 
            // dgv_DS_PhieuThiTien
            // 
            this.dgv_DS_PhieuThiTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DS_PhieuThiTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DS_PhieuThiTien.Location = new System.Drawing.Point(0, -5);
            this.dgv_DS_PhieuThiTien.Name = "dgv_DS_PhieuThiTien";
            this.dgv_DS_PhieuThiTien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_DS_PhieuThiTien.Size = new System.Drawing.Size(1042, 150);
            this.dgv_DS_PhieuThiTien.TabIndex = 0;
            this.dgv_DS_PhieuThiTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DS_PhieuThiTien_CellClick);
            // 
            // lbl_CTPTTP_MP
            // 
            this.lbl_CTPTTP_MP.AutoSize = true;
            this.lbl_CTPTTP_MP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CTPTTP_MP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_CTPTTP_MP.Location = new System.Drawing.Point(12, 384);
            this.lbl_CTPTTP_MP.Name = "lbl_CTPTTP_MP";
            this.lbl_CTPTTP_MP.Size = new System.Drawing.Size(444, 24);
            this.lbl_CTPTTP_MP.TabIndex = 29;
            this.lbl_CTPTTP_MP.Text = "DANH SÁCH PHIẾU THU TIỀN CỦA PHÒNG : ";
            // 
            // grb_PhongChiTiet
            // 
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienNuoc);
            this.grb_PhongChiTiet.Controls.Add(this.label9);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienPhong);
            this.grb_PhongChiTiet.Controls.Add(this.label8);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TrangThai);
            this.grb_PhongChiTiet.Controls.Add(this.label7);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienDien);
            this.grb_PhongChiTiet.Controls.Add(this.label6);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienDatCoc);
            this.grb_PhongChiTiet.Controls.Add(this.label5);
            this.grb_PhongChiTiet.Controls.Add(this.txt_SoTang);
            this.grb_PhongChiTiet.Controls.Add(this.label4);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TenNguoiThu);
            this.grb_PhongChiTiet.Controls.Add(this.label3);
            this.grb_PhongChiTiet.Controls.Add(this.txt_MaNhaTro);
            this.grb_PhongChiTiet.Controls.Add(this.label11);
            this.grb_PhongChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grb_PhongChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_PhongChiTiet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grb_PhongChiTiet.Location = new System.Drawing.Point(16, 97);
            this.grb_PhongChiTiet.Name = "grb_PhongChiTiet";
            this.grb_PhongChiTiet.Size = new System.Drawing.Size(500, 220);
            this.grb_PhongChiTiet.TabIndex = 30;
            this.grb_PhongChiTiet.TabStop = false;
            this.grb_PhongChiTiet.Text = "Thông tin phòng";
            // 
            // txt_TienNuoc
            // 
            this.txt_TienNuoc.Location = new System.Drawing.Point(359, 162);
            this.txt_TienNuoc.Name = "txt_TienNuoc";
            this.txt_TienNuoc.Size = new System.Drawing.Size(106, 22);
            this.txt_TienNuoc.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(245, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tiền nước:";
            // 
            // txt_TienPhong
            // 
            this.txt_TienPhong.Location = new System.Drawing.Point(359, 120);
            this.txt_TienPhong.Name = "txt_TienPhong";
            this.txt_TienPhong.Size = new System.Drawing.Size(106, 22);
            this.txt_TienPhong.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(245, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tiền phòng:";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(359, 79);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(106, 22);
            this.txt_TrangThai.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(245, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Trạng thái:";
            // 
            // txt_TienDien
            // 
            this.txt_TienDien.Location = new System.Drawing.Point(107, 162);
            this.txt_TienDien.Name = "txt_TienDien";
            this.txt_TienDien.Size = new System.Drawing.Size(106, 22);
            this.txt_TienDien.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(4, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tiền điện:";
            // 
            // txt_TienDatCoc
            // 
            this.txt_TienDatCoc.Location = new System.Drawing.Point(107, 117);
            this.txt_TienDatCoc.Name = "txt_TienDatCoc";
            this.txt_TienDatCoc.Size = new System.Drawing.Size(106, 22);
            this.txt_TienDatCoc.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(4, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tiền đặt cọc:";
            // 
            // txt_SoTang
            // 
            this.txt_SoTang.Location = new System.Drawing.Point(107, 76);
            this.txt_SoTang.Name = "txt_SoTang";
            this.txt_SoTang.Size = new System.Drawing.Size(62, 22);
            this.txt_SoTang.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số tầng:";
            // 
            // txt_TenNguoiThu
            // 
            this.txt_TenNguoiThu.Location = new System.Drawing.Point(359, 31);
            this.txt_TenNguoiThu.Name = "txt_TenNguoiThu";
            this.txt_TenNguoiThu.Size = new System.Drawing.Size(135, 22);
            this.txt_TenNguoiThu.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(245, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên người thuê:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ThangPT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_TongTienPT);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.txt_TienNuocPT);
            this.groupBox1.Controls.Add(this.lbl_TienNuocPT);
            this.groupBox1.Controls.Add(this.txt_TrangThaiPT);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_TienPhongPT);
            this.groupBox1.Controls.Add(this.lbl_TienPhongPT);
            this.groupBox1.Controls.Add(this.txt_TienDienPT);
            this.groupBox1.Controls.Add(this.lbl_TienDienPT);
            this.groupBox1.Controls.Add(this.txt_MaHopDong);
            this.groupBox1.Controls.Add(this.lbl_MaHopDong);
            this.groupBox1.Controls.Add(this.txt_MaPhieu);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(533, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 220);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu thu tiền";
            // 
            // txt_ThangPT
            // 
            this.txt_ThangPT.Location = new System.Drawing.Point(359, 162);
            this.txt_ThangPT.Name = "txt_ThangPT";
            this.txt_ThangPT.Size = new System.Drawing.Size(106, 22);
            this.txt_ThangPT.TabIndex = 41;
            this.txt_ThangPT.TextChanged += new System.EventHandler(this.txt_ThangPT_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(245, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tháng:";
            // 
            // txt_TongTienPT
            // 
            this.txt_TongTienPT.Location = new System.Drawing.Point(359, 120);
            this.txt_TongTienPT.Name = "txt_TongTienPT";
            this.txt_TongTienPT.Size = new System.Drawing.Size(106, 22);
            this.txt_TongTienPT.TabIndex = 39;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb.Location = new System.Drawing.Point(245, 123);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(77, 16);
            this.lb.TabIndex = 38;
            this.lb.Text = "Tổng tiền:";
            // 
            // txt_TienNuocPT
            // 
            this.txt_TienNuocPT.Location = new System.Drawing.Point(359, 79);
            this.txt_TienNuocPT.Name = "txt_TienNuocPT";
            this.txt_TienNuocPT.Size = new System.Drawing.Size(106, 22);
            this.txt_TienNuocPT.TabIndex = 37;
            // 
            // lbl_TienNuocPT
            // 
            this.lbl_TienNuocPT.AutoSize = true;
            this.lbl_TienNuocPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienNuocPT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_TienNuocPT.Location = new System.Drawing.Point(245, 82);
            this.lbl_TienNuocPT.Name = "lbl_TienNuocPT";
            this.lbl_TienNuocPT.Size = new System.Drawing.Size(80, 16);
            this.lbl_TienNuocPT.TabIndex = 36;
            this.lbl_TienNuocPT.Text = "Tiền nước:";
            // 
            // txt_TrangThaiPT
            // 
            this.txt_TrangThaiPT.Location = new System.Drawing.Point(107, 162);
            this.txt_TrangThaiPT.Name = "txt_TrangThaiPT";
            this.txt_TrangThaiPT.Size = new System.Drawing.Size(106, 22);
            this.txt_TrangThaiPT.TabIndex = 35;
            this.txt_TrangThaiPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TrangThaiPT_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(4, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Trạng thái:";
            // 
            // txt_TienPhongPT
            // 
            this.txt_TienPhongPT.Location = new System.Drawing.Point(107, 117);
            this.txt_TienPhongPT.Name = "txt_TienPhongPT";
            this.txt_TienPhongPT.Size = new System.Drawing.Size(106, 22);
            this.txt_TienPhongPT.TabIndex = 33;
            // 
            // lbl_TienPhongPT
            // 
            this.lbl_TienPhongPT.AutoSize = true;
            this.lbl_TienPhongPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienPhongPT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_TienPhongPT.Location = new System.Drawing.Point(4, 120);
            this.lbl_TienPhongPT.Name = "lbl_TienPhongPT";
            this.lbl_TienPhongPT.Size = new System.Drawing.Size(91, 16);
            this.lbl_TienPhongPT.TabIndex = 32;
            this.lbl_TienPhongPT.Text = "Tiền Phòng:";
            // 
            // txt_TienDienPT
            // 
            this.txt_TienDienPT.Location = new System.Drawing.Point(107, 76);
            this.txt_TienDienPT.Name = "txt_TienDienPT";
            this.txt_TienDienPT.Size = new System.Drawing.Size(62, 22);
            this.txt_TienDienPT.TabIndex = 31;
            // 
            // lbl_TienDienPT
            // 
            this.lbl_TienDienPT.AutoSize = true;
            this.lbl_TienDienPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienDienPT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_TienDienPT.Location = new System.Drawing.Point(4, 79);
            this.lbl_TienDienPT.Name = "lbl_TienDienPT";
            this.lbl_TienDienPT.Size = new System.Drawing.Size(77, 16);
            this.lbl_TienDienPT.TabIndex = 30;
            this.lbl_TienDienPT.Text = "Tiền điện:";
            // 
            // txt_MaHopDong
            // 
            this.txt_MaHopDong.Location = new System.Drawing.Point(359, 31);
            this.txt_MaHopDong.Name = "txt_MaHopDong";
            this.txt_MaHopDong.Size = new System.Drawing.Size(135, 22);
            this.txt_MaHopDong.TabIndex = 29;
            // 
            // lbl_MaHopDong
            // 
            this.lbl_MaHopDong.AutoSize = true;
            this.lbl_MaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHopDong.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_MaHopDong.Location = new System.Drawing.Point(245, 37);
            this.lbl_MaHopDong.Name = "lbl_MaHopDong";
            this.lbl_MaHopDong.Size = new System.Drawing.Size(102, 16);
            this.lbl_MaHopDong.TabIndex = 28;
            this.lbl_MaHopDong.Text = "Mã hợp đồng:";
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(107, 31);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Size = new System.Drawing.Size(62, 22);
            this.txt_MaPhieu.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(4, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "Mã phiếu:";
            // 
            // btn_InPT
            // 
            this.btn_InPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InPT.AutoSize = true;
            this.btn_InPT.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_InPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InPT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_InPT.Image = global::TEST_WINFORM.Properties.Resources.print;
            this.btn_InPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InPT.Location = new System.Drawing.Point(508, 373);
            this.btn_InPT.Name = "btn_InPT";
            this.btn_InPT.Size = new System.Drawing.Size(138, 32);
            this.btn_InPT.TabIndex = 47;
            this.btn_InPT.Text = "In phiếu thu";
            this.btn_InPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InPT.UseVisualStyleBackColor = false;
            this.btn_InPT.Click += new System.EventHandler(this.btn_InPT_Click);
            // 
            // btn_XemNguoiThue
            // 
            this.btn_XemNguoiThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemNguoiThue.AutoSize = true;
            this.btn_XemNguoiThue.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_XemNguoiThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemNguoiThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_XemNguoiThue.Image = global::TEST_WINFORM.Properties.Resources.see;
            this.btn_XemNguoiThue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemNguoiThue.Location = new System.Drawing.Point(664, 323);
            this.btn_XemNguoiThue.Name = "btn_XemNguoiThue";
            this.btn_XemNguoiThue.Size = new System.Drawing.Size(138, 32);
            this.btn_XemNguoiThue.TabIndex = 46;
            this.btn_XemNguoiThue.Text = "Xem người thuê";
            this.btn_XemNguoiThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XemNguoiThue.UseVisualStyleBackColor = false;
            this.btn_XemNguoiThue.Click += new System.EventHandler(this.btn_XemNguoiThue_Click);
            // 
            // btn_XoaPT
            // 
            this.btn_XoaPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XoaPT.AutoSize = true;
            this.btn_XoaPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_XoaPT.Image = global::TEST_WINFORM.Properties.Resources.delete;
            this.btn_XoaPT.Location = new System.Drawing.Point(818, 373);
            this.btn_XoaPT.Name = "btn_XoaPT";
            this.btn_XoaPT.Size = new System.Drawing.Size(138, 32);
            this.btn_XoaPT.TabIndex = 45;
            this.btn_XoaPT.Text = "Xóa phiếu thu";
            this.btn_XoaPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaPT.UseVisualStyleBackColor = false;
            this.btn_XoaPT.Click += new System.EventHandler(this.btn_XoaPT_Click);
            // 
            // btn_ChinhPT
            // 
            this.btn_ChinhPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChinhPT.AutoSize = true;
            this.btn_ChinhPT.BackColor = System.Drawing.Color.Green;
            this.btn_ChinhPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChinhPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChinhPT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ChinhPT.Image = global::TEST_WINFORM.Properties.Resources.edit;
            this.btn_ChinhPT.Location = new System.Drawing.Point(818, 323);
            this.btn_ChinhPT.Name = "btn_ChinhPT";
            this.btn_ChinhPT.Size = new System.Drawing.Size(138, 32);
            this.btn_ChinhPT.TabIndex = 44;
            this.btn_ChinhPT.Text = "Chỉnh phiếu thu";
            this.btn_ChinhPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChinhPT.UseVisualStyleBackColor = false;
            this.btn_ChinhPT.Click += new System.EventHandler(this.btn_ChinhPT_Click);
            // 
            // btn_ThemPT
            // 
            this.btn_ThemPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemPT.AutoSize = true;
            this.btn_ThemPT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ThemPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemPT.Image = global::TEST_WINFORM.Properties.Resources.add;
            this.btn_ThemPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemPT.Location = new System.Drawing.Point(664, 373);
            this.btn_ThemPT.Name = "btn_ThemPT";
            this.btn_ThemPT.Size = new System.Drawing.Size(138, 32);
            this.btn_ThemPT.TabIndex = 43;
            this.btn_ThemPT.Text = "Thêm phiếu thu";
            this.btn_ThemPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemPT.UseVisualStyleBackColor = false;
            this.btn_ThemPT.Click += new System.EventHandler(this.btn_ThemPT_Click);
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
            this.btn_QuyLai.Location = new System.Drawing.Point(904, 23);
            this.btn_QuyLai.Name = "btn_QuyLai";
            this.btn_QuyLai.Size = new System.Drawing.Size(126, 39);
            this.btn_QuyLai.TabIndex = 7;
            this.btn_QuyLai.Text = "Quay lại";
            this.btn_QuyLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuyLai.UseVisualStyleBackColor = false;
            this.btn_QuyLai.Click += new System.EventHandler(this.btn_QuyLai_Click);
            // 
            // Chi_Tiet_Phong_Tro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 561);
            this.Controls.Add(this.btn_InPT);
            this.Controls.Add(this.btn_XemNguoiThue);
            this.Controls.Add(this.btn_XoaPT);
            this.Controls.Add(this.btn_ChinhPT);
            this.Controls.Add(this.btn_ThemPT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_PhongChiTiet);
            this.Controls.Add(this.lbl_CTPTTP_MP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_MaPhongCT);
            this.Controls.Add(this.btn_QuyLai);
            this.Name = "Chi_Tiet_Phong_Tro";
            this.Text = "Chi_Tiet_Phong_Tro";
            this.Load += new System.EventHandler(this.Chi_Tiet_Phong_Tro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_PhieuThiTien)).EndInit();
            this.grb_PhongChiTiet.ResumeLayout(false);
            this.grb_PhongChiTiet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MaPhongCT;
        private System.Windows.Forms.Button btn_QuyLai;
        private System.Windows.Forms.TextBox txt_MaNhaTro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DS_PhieuThiTien;
        private System.Windows.Forms.Label lbl_CTPTTP_MP;
        private System.Windows.Forms.GroupBox grb_PhongChiTiet;
        private System.Windows.Forms.TextBox txt_TienDien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TienDatCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoTang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenNguoiThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TienNuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TienPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ThangPT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TongTienPT;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txt_TienNuocPT;
        private System.Windows.Forms.Label lbl_TienNuocPT;
        private System.Windows.Forms.TextBox txt_TrangThaiPT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_TienPhongPT;
        private System.Windows.Forms.Label lbl_TienPhongPT;
        private System.Windows.Forms.TextBox txt_TienDienPT;
        private System.Windows.Forms.Label lbl_TienDienPT;
        private System.Windows.Forms.TextBox txt_MaHopDong;
        private System.Windows.Forms.Label lbl_MaHopDong;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_XemNguoiThue;
        private System.Windows.Forms.Button btn_XoaPT;
        private System.Windows.Forms.Button btn_ChinhPT;
        private System.Windows.Forms.Button btn_ThemPT;
        private System.Windows.Forms.Button btn_InPT;
    }
}