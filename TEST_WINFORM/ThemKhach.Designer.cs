
namespace TEST_WINFORM
{
    partial class ThemKhach
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
            this.btn_QuyLai = new System.Windows.Forms.Button();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.lbl_TienDienPT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TienCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.dateTime_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.btn_ThemNguoiThueNhanh = new System.Windows.Forms.Button();
            this.cbb_TenNguoiThue = new System.Windows.Forms.ComboBox();
            this.btn_TaoHopDong = new System.Windows.Forms.Button();
            this.btn_TaoHongDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________";
            // 
            // lbl_MaPhongCT
            // 
            this.lbl_MaPhongCT.AutoSize = true;
            this.lbl_MaPhongCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaPhongCT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_MaPhongCT.Location = new System.Drawing.Point(9, 19);
            this.lbl_MaPhongCT.Name = "lbl_MaPhongCT";
            this.lbl_MaPhongCT.Size = new System.Drawing.Size(256, 24);
            this.lbl_MaPhongCT.TabIndex = 13;
            this.lbl_MaPhongCT.Text = "Tạo hợp đồng thuê phòng";
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
            this.btn_QuyLai.Location = new System.Drawing.Point(568, 14);
            this.btn_QuyLai.Name = "btn_QuyLai";
            this.btn_QuyLai.Size = new System.Drawing.Size(126, 39);
            this.btn_QuyLai.TabIndex = 15;
            this.btn_QuyLai.Text = "Quay lại";
            this.btn_QuyLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuyLai.UseVisualStyleBackColor = false;
            this.btn_QuyLai.Click += new System.EventHandler(this.btn_QuyLai_Click);
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(136, 86);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(62, 20);
            this.txt_MaPhong.TabIndex = 39;
            // 
            // lbl_TienDienPT
            // 
            this.lbl_TienDienPT.AutoSize = true;
            this.lbl_TienDienPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienDienPT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_TienDienPT.Location = new System.Drawing.Point(12, 90);
            this.lbl_TienDienPT.Name = "lbl_TienDienPT";
            this.lbl_TienDienPT.Size = new System.Drawing.Size(81, 16);
            this.lbl_TienDienPT.TabIndex = 38;
            this.lbl_TienDienPT.Text = "Mã Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(381, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên Người Thuê:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày Bắt Đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // txt_TienCoc
            // 
            this.txt_TienCoc.Location = new System.Drawing.Point(510, 178);
            this.txt_TienCoc.Name = "txt_TienCoc";
            this.txt_TienCoc.Size = new System.Drawing.Size(126, 20);
            this.txt_TienCoc.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(381, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tiền Cọc:";
            // 
            // dateTime_NgayBD
            // 
            this.dateTime_NgayBD.Location = new System.Drawing.Point(136, 131);
            this.dateTime_NgayBD.Name = "dateTime_NgayBD";
            this.dateTime_NgayBD.Size = new System.Drawing.Size(189, 20);
            this.dateTime_NgayBD.TabIndex = 48;
            // 
            // dateTime_NgayKT
            // 
            this.dateTime_NgayKT.Location = new System.Drawing.Point(136, 182);
            this.dateTime_NgayKT.Name = "dateTime_NgayKT";
            this.dateTime_NgayKT.Size = new System.Drawing.Size(189, 20);
            this.dateTime_NgayKT.TabIndex = 49;
            // 
            // btn_ThemNguoiThueNhanh
            // 
            this.btn_ThemNguoiThueNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemNguoiThueNhanh.AutoSize = true;
            this.btn_ThemNguoiThueNhanh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ThemNguoiThueNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNguoiThueNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNguoiThueNhanh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemNguoiThueNhanh.Image = global::TEST_WINFORM.Properties.Resources.add;
            this.btn_ThemNguoiThueNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemNguoiThueNhanh.Location = new System.Drawing.Point(510, 127);
            this.btn_ThemNguoiThueNhanh.Name = "btn_ThemNguoiThueNhanh";
            this.btn_ThemNguoiThueNhanh.Size = new System.Drawing.Size(177, 32);
            this.btn_ThemNguoiThueNhanh.TabIndex = 51;
            this.btn_ThemNguoiThueNhanh.Text = "Thêm người thuê nhanh";
            this.btn_ThemNguoiThueNhanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemNguoiThueNhanh.UseVisualStyleBackColor = false;
            // 
            // cbb_TenNguoiThue
            // 
            this.cbb_TenNguoiThue.FormattingEnabled = true;
            this.cbb_TenNguoiThue.Location = new System.Drawing.Point(510, 85);
            this.cbb_TenNguoiThue.Name = "cbb_TenNguoiThue";
            this.cbb_TenNguoiThue.Size = new System.Drawing.Size(126, 21);
            this.cbb_TenNguoiThue.TabIndex = 52;
            // 
            // btn_TaoHopDong
            // 
            this.btn_TaoHopDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TaoHopDong.AutoSize = true;
            this.btn_TaoHopDong.BackColor = System.Drawing.Color.Green;
            this.btn_TaoHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHopDong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TaoHopDong.Image = global::TEST_WINFORM.Properties.Resources.edit;
            this.btn_TaoHopDong.Location = new System.Drawing.Point(508, 219);
            this.btn_TaoHopDong.Name = "btn_TaoHopDong";
            this.btn_TaoHopDong.Size = new System.Drawing.Size(186, 32);
            this.btn_TaoHopDong.TabIndex = 53;
            this.btn_TaoHopDong.Text = "Xác Nhận Tạo Hợp Đồng";
            this.btn_TaoHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoHopDong.UseVisualStyleBackColor = false;
            // 
            // btn_TaoHongDong
            // 
            this.btn_TaoHongDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TaoHongDong.AutoSize = true;
            this.btn_TaoHongDong.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_TaoHongDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHongDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHongDong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TaoHongDong.Image = global::TEST_WINFORM.Properties.Resources.print;
            this.btn_TaoHongDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoHongDong.Location = new System.Drawing.Point(339, 219);
            this.btn_TaoHongDong.Name = "btn_TaoHongDong";
            this.btn_TaoHongDong.Size = new System.Drawing.Size(138, 32);
            this.btn_TaoHongDong.TabIndex = 54;
            this.btn_TaoHongDong.Text = "Tạo Hợp Đồng";
            this.btn_TaoHongDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoHongDong.UseVisualStyleBackColor = false;
            // 
            // ThemKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 263);
            this.Controls.Add(this.btn_TaoHongDong);
            this.Controls.Add(this.btn_TaoHopDong);
            this.Controls.Add(this.cbb_TenNguoiThue);
            this.Controls.Add(this.btn_ThemNguoiThueNhanh);
            this.Controls.Add(this.dateTime_NgayKT);
            this.Controls.Add(this.dateTime_NgayBD);
            this.Controls.Add(this.txt_TienCoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaPhong);
            this.Controls.Add(this.lbl_TienDienPT);
            this.Controls.Add(this.btn_QuyLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_MaPhongCT);
            this.Name = "ThemKhach";
            this.Text = "ThemKhach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QuyLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MaPhongCT;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Label lbl_TienDienPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TienCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime_NgayBD;
        private System.Windows.Forms.DateTimePicker dateTime_NgayKT;
        private System.Windows.Forms.Button btn_ThemNguoiThueNhanh;
        private System.Windows.Forms.ComboBox cbb_TenNguoiThue;
        private System.Windows.Forms.Button btn_TaoHopDong;
        private System.Windows.Forms.Button btn_TaoHongDong;
    }
}