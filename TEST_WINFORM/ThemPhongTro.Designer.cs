
namespace TEST_WINFORM
{
    partial class ThemPhongTro
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
            this.lbl_PhongTro = new System.Windows.Forms.Label();
            this.btn_QuyLai = new System.Windows.Forms.Button();
            this.grb_PhongChiTiet = new System.Windows.Forms.GroupBox();
            this.cbb_NhaTro = new System.Windows.Forms.ComboBox();
            this.txt_TienNuoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TienPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TienDien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TienDatCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoTang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ChinhPT = new System.Windows.Forms.Button();
            this.lbl_MaPhong = new System.Windows.Forms.Label();
            this.grb_PhongChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // lbl_PhongTro
            // 
            this.lbl_PhongTro.AutoSize = true;
            this.lbl_PhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhongTro.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_PhongTro.Location = new System.Drawing.Point(12, 27);
            this.lbl_PhongTro.Name = "lbl_PhongTro";
            this.lbl_PhongTro.Size = new System.Drawing.Size(249, 24);
            this.lbl_PhongTro.TabIndex = 10;
            this.lbl_PhongTro.Text = "CHI TIẾT PHÒNG THUÊ: ";
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
            this.btn_QuyLai.Location = new System.Drawing.Point(502, 12);
            this.btn_QuyLai.Name = "btn_QuyLai";
            this.btn_QuyLai.Size = new System.Drawing.Size(115, 39);
            this.btn_QuyLai.TabIndex = 12;
            this.btn_QuyLai.Text = "Quay lại";
            this.btn_QuyLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuyLai.UseVisualStyleBackColor = false;
            this.btn_QuyLai.Click += new System.EventHandler(this.btn_QuyLai_Click);
            // 
            // grb_PhongChiTiet
            // 
            this.grb_PhongChiTiet.Controls.Add(this.cbb_NhaTro);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienNuoc);
            this.grb_PhongChiTiet.Controls.Add(this.label9);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienPhong);
            this.grb_PhongChiTiet.Controls.Add(this.label8);
            this.grb_PhongChiTiet.Controls.Add(this.label7);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienDien);
            this.grb_PhongChiTiet.Controls.Add(this.label6);
            this.grb_PhongChiTiet.Controls.Add(this.txt_TienDatCoc);
            this.grb_PhongChiTiet.Controls.Add(this.label5);
            this.grb_PhongChiTiet.Controls.Add(this.txt_SoTang);
            this.grb_PhongChiTiet.Controls.Add(this.label4);
            this.grb_PhongChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grb_PhongChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_PhongChiTiet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grb_PhongChiTiet.Location = new System.Drawing.Point(16, 91);
            this.grb_PhongChiTiet.Name = "grb_PhongChiTiet";
            this.grb_PhongChiTiet.Size = new System.Drawing.Size(601, 220);
            this.grb_PhongChiTiet.TabIndex = 31;
            this.grb_PhongChiTiet.TabStop = false;
            this.grb_PhongChiTiet.Text = "Thông tin phòng";
            // 
            // cbb_NhaTro
            // 
            this.cbb_NhaTro.FormattingEnabled = true;
            this.cbb_NhaTro.Location = new System.Drawing.Point(461, 126);
            this.cbb_NhaTro.Name = "cbb_NhaTro";
            this.cbb_NhaTro.Size = new System.Drawing.Size(121, 24);
            this.cbb_NhaTro.TabIndex = 42;
            // 
            // txt_TienNuoc
            // 
            this.txt_TienNuoc.Location = new System.Drawing.Point(461, 82);
            this.txt_TienNuoc.Name = "txt_TienNuoc";
            this.txt_TienNuoc.Size = new System.Drawing.Size(106, 22);
            this.txt_TienNuoc.TabIndex = 41;
            this.txt_TienNuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TienNuoc_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(347, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tiền nước:";
            // 
            // txt_TienPhong
            // 
            this.txt_TienPhong.Location = new System.Drawing.Point(461, 40);
            this.txt_TienPhong.Name = "txt_TienPhong";
            this.txt_TienPhong.Size = new System.Drawing.Size(106, 22);
            this.txt_TienPhong.TabIndex = 39;
            this.txt_TienPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TienPhong_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(347, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tiền phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(347, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nhà Trọ:";
            // 
            // txt_TienDien
            // 
            this.txt_TienDien.Location = new System.Drawing.Point(113, 123);
            this.txt_TienDien.Name = "txt_TienDien";
            this.txt_TienDien.Size = new System.Drawing.Size(106, 22);
            this.txt_TienDien.TabIndex = 35;
            this.txt_TienDien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TienDien_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(10, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tiền điện:";
            // 
            // txt_TienDatCoc
            // 
            this.txt_TienDatCoc.Location = new System.Drawing.Point(113, 78);
            this.txt_TienDatCoc.Name = "txt_TienDatCoc";
            this.txt_TienDatCoc.Size = new System.Drawing.Size(106, 22);
            this.txt_TienDatCoc.TabIndex = 33;
            this.txt_TienDatCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TienDatCoc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tiền đặt cọc:";
            // 
            // txt_SoTang
            // 
            this.txt_SoTang.Location = new System.Drawing.Point(113, 37);
            this.txt_SoTang.Name = "txt_SoTang";
            this.txt_SoTang.Size = new System.Drawing.Size(62, 22);
            this.txt_SoTang.TabIndex = 31;
            this.txt_SoTang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTang_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số tầng:";
            // 
            // btn_ChinhPT
            // 
            this.btn_ChinhPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChinhPT.AutoSize = true;
            this.btn_ChinhPT.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ChinhPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChinhPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChinhPT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ChinhPT.Image = global::TEST_WINFORM.Properties.Resources._18837429041582692250_32;
            this.btn_ChinhPT.Location = new System.Drawing.Point(477, 313);
            this.btn_ChinhPT.Name = "btn_ChinhPT";
            this.btn_ChinhPT.Size = new System.Drawing.Size(140, 40);
            this.btn_ChinhPT.TabIndex = 45;
            this.btn_ChinhPT.Text = "Thêm Phòng";
            this.btn_ChinhPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChinhPT.UseVisualStyleBackColor = false;
            this.btn_ChinhPT.Click += new System.EventHandler(this.btn_ChinhPT_Click);
            // 
            // lbl_MaPhong
            // 
            this.lbl_MaPhong.AutoSize = true;
            this.lbl_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaPhong.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_MaPhong.Location = new System.Drawing.Point(261, 27);
            this.lbl_MaPhong.Name = "lbl_MaPhong";
            this.lbl_MaPhong.Size = new System.Drawing.Size(0, 24);
            this.lbl_MaPhong.TabIndex = 46;
            // 
            // ThemPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 365);
            this.Controls.Add(this.lbl_MaPhong);
            this.Controls.Add(this.btn_ChinhPT);
            this.Controls.Add(this.grb_PhongChiTiet);
            this.Controls.Add(this.btn_QuyLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_PhongTro);
            this.Name = "ThemPhongTro";
            this.Text = "ThemPhongTro";
            this.Load += new System.EventHandler(this.ThemPhongTro_Load);
            this.grb_PhongChiTiet.ResumeLayout(false);
            this.grb_PhongChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_PhongTro;
        private System.Windows.Forms.Button btn_QuyLai;
        private System.Windows.Forms.GroupBox grb_PhongChiTiet;
        private System.Windows.Forms.ComboBox cbb_NhaTro;
        private System.Windows.Forms.TextBox txt_TienNuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TienPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TienDien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TienDatCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoTang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ChinhPT;
        private System.Windows.Forms.Label lbl_MaPhong;
    }
}