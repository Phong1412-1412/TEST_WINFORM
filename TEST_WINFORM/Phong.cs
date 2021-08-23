using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_WINFORM
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
          
        }
        Panel A = null;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            HienThiTatCa();
            QUERY_DB_QLNT.TongPhong(lbl_TongPhong);
            lbl_PhongTrong.Text += QUERY_DB_QLNT.TongPhongTRONG().ToString();
            lbl_PhongDangChoThue.Text += QUERY_DB_QLNT.TongPhongDaChoThue().ToString();
            HienThi_NhaTro();
        }

        //------------------------Hiện thị nhà trọ cbb in menustrip------------------------
        public void HienThi_NhaTro()
        {
            QUERY_DB_QLNT.HienThiCBB("Select * from Nha_Tro","MaNhaTro","MaNhaTro",cbb_NhaTro);
        }

        //-----------------END: Hiện thị nhà trọ cbb in menustrip--------------------------------
        //-------------------------------------------------HÀM DÙNG ĐỂ TẠO PHÒNG----------------------------------------
        int sl = QUERY_DB_QLNT.TongPhongINT();
        int x = 40;
        int y = 180;
        int KCX = 370 - 40;
        int KCY = 390 - 100;
        string query = "";
        int[] ARRMP = new int[100];
        Label lbl_MaPhong = null;
        Button btn_Tra = null;
        private void ThongTinPhong(string qr,int tongPhong,int i)
        {

            for (i = 1; i <= tongPhong; i++)
            {

                A = new Panel();
                Panel IconPhong = new Panel();
                Button btn_ChinhSuaPhong = new Button();
                IconPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
                IconPhong.BackgroundImage = global::TEST_WINFORM.Properties.Resources._18837429041582692250_32;
                IconPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                IconPhong.Location = new System.Drawing.Point(13, 7);
                IconPhong.Name = "panel_IconPhong";
                IconPhong.Size = new System.Drawing.Size(32, 30);
                IconPhong.TabIndex = 2;
                //-----------------------------------------------------------------------------------
                btn_ChinhSuaPhong.AutoSize = true;
                btn_ChinhSuaPhong.BackColor = System.Drawing.Color.Green;
                btn_ChinhSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_ChinhSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn_ChinhSuaPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btn_ChinhSuaPhong.Location = new System.Drawing.Point(13, 171);
                btn_ChinhSuaPhong.Name = "btn_ChinhSuaPhong";
                btn_ChinhSuaPhong.Size = new System.Drawing.Size(81, 25);
                btn_ChinhSuaPhong.TabIndex = 16;
                btn_ChinhSuaPhong.Text = "Chỉnh sửa";
                btn_ChinhSuaPhong.UseVisualStyleBackColor = false;
               
                //-------------------------------------------------------------------------------------
                Button btn_XoaPhong = new Button();
                btn_XoaPhong.AutoSize = true;
                btn_XoaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                btn_XoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_XoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn_XoaPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btn_XoaPhong.Location = new System.Drawing.Point(101, 171);
                btn_XoaPhong.Name = "btn_XoaPhong";
                btn_XoaPhong.Size = new System.Drawing.Size(81, 25);
                btn_XoaPhong.TabIndex = 16;
                btn_XoaPhong.Text = "Xóa phòng";
                btn_XoaPhong.UseVisualStyleBackColor = false;
 
                //-------------------------------------------------------------------------------------
                btn_Tra = new Button();
                btn_Tra.AutoSize = true;
                btn_Tra.BackColor = System.Drawing.Color.DarkCyan;
                btn_Tra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn_Tra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btn_Tra.Location = new System.Drawing.Point(13, 52);
                btn_Tra.Name = "btn_Tra";
                btn_Tra.Size = new System.Drawing.Size(45, 25);
                btn_Tra.TabIndex = 8;
                btn_Tra.Text = "Trả";
                btn_Tra.UseVisualStyleBackColor = false;
                //-------------------------------------------------------------------------------------
                Button btn_Sua = new Button();
                btn_Sua.AutoSize = true;
                btn_Sua.BackColor = System.Drawing.Color.DimGray;
                btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btn_Sua.Location = new System.Drawing.Point(137, 52);
                btn_Sua.Name = "btn_Sua";
                btn_Sua.Size = new System.Drawing.Size(45, 25);
                btn_Sua.TabIndex = 10;
                btn_Sua.Text = "Sửa";
                btn_Sua.UseVisualStyleBackColor = false;
                //-------------------------------------------------------------------------------------
                Button btn_Xem = new Button();
                btn_Xem.AutoSize = true;
                btn_Xem.BackColor = System.Drawing.Color.LightSkyBlue;
                btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn_Xem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btn_Xem.Location = new System.Drawing.Point(75, 52);
                btn_Xem.Name = "btn_Xem";
                btn_Xem.Size = new System.Drawing.Size(45, 25);
                btn_Xem.TabIndex = 9;
                btn_Xem.Text = "Xem";
                btn_Xem.UseVisualStyleBackColor = false;
                btn_Xem.Click += new System.EventHandler(buttonXem);
                //-------------------------------------------------------------------------------------
                lbl_MaPhong = new Label();
                lbl_MaPhong.AutoSize = true;
                lbl_MaPhong.Location = new System.Drawing.Point(51, 14);
                lbl_MaPhong.Name = "";
                lbl_MaPhong.Size = new System.Drawing.Size(60, 16);
                lbl_MaPhong.TabIndex = 0;
                lbl_MaPhong.Text = "Phòng: ";
                //-------------------------------------------------------------------------------------
                Label lbl_TrangThaiPhong = new Label();
                lbl_TrangThaiPhong.AutoSize = true;
                lbl_TrangThaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                lbl_TrangThaiPhong.Location = new System.Drawing.Point(12, 90);
                lbl_TrangThaiPhong.Name = "lbl_TrangThaiPhong";
                lbl_TrangThaiPhong.Size = new System.Drawing.Size(43, 16);
                lbl_TrangThaiPhong.TabIndex = 12;
                lbl_TrangThaiPhong.Text = "Trạng thái:";
                //-------------------------------------------------------------------------------------
                Label lbl_GiaThue = new Label();
                lbl_GiaThue.AutoSize = true;
                lbl_GiaThue.ForeColor = System.Drawing.Color.DarkRed;
                lbl_GiaThue.Location = new System.Drawing.Point(12, 121);
                lbl_GiaThue.Name = "lbl_GiaThue";
                lbl_GiaThue.Size = new System.Drawing.Size(36, 16);
                lbl_GiaThue.TabIndex = 11;
                lbl_GiaThue.Text = "Giá:";
                //-------------------------------------------------------------------------------------
                //QUERY_DB_QLNT.HienThiPhong(lbl_MaPhong, lbl_TrangThaiPhong, lbl_GiaThue,qr);
               
                //-------------------------------------------------------------------------------------
                A.BackColor = System.Drawing.SystemColors.ActiveCaption;
                A.Controls.Add(IconPhong);
                A.Controls.Add(btn_ChinhSuaPhong);
                A.Controls.Add(btn_XoaPhong);
                A.Controls.Add(btn_Tra);
                A.Controls.Add(btn_Sua);
                A.Controls.Add(btn_Xem);
                A.Controls.Add(lbl_MaPhong);
                A.Controls.Add(lbl_TrangThaiPhong);
                A.Controls.Add(lbl_GiaThue);
                A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                A.Location = new System.Drawing.Point(x, y);
                A.Name = i.ToString();
                A.Size = new System.Drawing.Size(200, 220);
                A.TabIndex = 13;
                this.panel_PhongChiTiet.Controls.Add(A);
                x += KCX;
                if (i >= 3 && i % 3 == 0)
                {
                    y += KCY;
                    x = 40;
                }
                QUERY_DB_QLNT.HienThiPhong_YC(qr, lbl_MaPhong, lbl_TrangThaiPhong, lbl_GiaThue, btn_Tra, btn_Sua, btn_Xem, A);
                ARRMP[int.Parse(lbl_MaPhong.Name)] = int.Parse(lbl_MaPhong.Name);
                btn_Tra.Click += new System.EventHandler(buttonClick);
            }
           
        }
        //------------------------------------------------------END-------------------------------------------------

        //-------------------------------------------------HÀM HIỂN THỊ THÔNG TIN PHÒNG --------------------------
        private void HienThiPhongTrong()
        {
            x = 40;
            y = 180;
            KCX = 370 - 40;
            KCY = 390 - 100;
            int i = 1;
            query = "select  MaPhongTro, GiaThue, TrangThai " + "FROM Phong_Tro " + "WHERE MaPhongTro = @MaPhong AND TrangThai = N'Trống'"
                          ;
            this.panel_PhongChiTiet.Controls.Clear();
            ThongTinPhong(query, QUERY_DB_QLNT.TongPhongTRONG(), i);
        }

        private void HienThiPhongThue()
        {
            x = 40;
            y = 180;
            KCX = 370 - 40;
            KCY = 390 - 100;
            int i = 1;
            query = "select  MaPhongTro, GiaThue, TrangThai " + "FROM Phong_Tro " + "WHERE MaPhongTro = @MaPhong AND TrangThai = N'Đã cho thuê'"
                          ;
            this.panel_PhongChiTiet.Controls.Clear();
            ThongTinPhong(query, QUERY_DB_QLNT.TongPhongDaChoThue(), i);
        }

        private void HienThiTatCa()
        {
            x = 40;
            y = 180;
            KCX = 370 - 40;
            KCY = 390 - 100;
            int i = 1;
            query = "select MaPhongTro, GiaThue, TrangThai " +
                    "FROM Phong_Tro " +
                    "WHERE MaPhongTro = @MaPhong";
            ;
            this.panel_PhongChiTiet.Controls.Clear();
            ThongTinPhong(query, QUERY_DB_QLNT.TongPhongINT(), i);
        }

        private void HienThiTheoNhaTro(int manha)
        {
            x = 40;
            y = 180;
            KCX = 370 - 40;
            KCY = 390 - 100;
            int i = 1;
            query = "select pt.MaPhongTro, pt.GiaThue, pt.TrangThai " +
                    "FROM Phong_Tro pt, Nha_Tro nt  " +
                    "WHERE pt.MaPhongTro = @MaPhong AND pt.MaNhaTro = '"+manha+"' ";
            this.panel_PhongChiTiet.Controls.Clear();
            ThongTinPhong(query,QUERY_DB_QLNT.TongPhongTheoNhatro(manha),i);
        }

        private void HienThiPhongDaDongTien()
        {
            x = 40;
            y = 180;
            KCX = 370 - 40;
            KCY = 390 - 100;
            int i = 1;
            query = "select hd.MaPhongTro, pdtp.TongTien, pdtp.TrangThai " +
                   "from PhieuDongTienPhong pdtp, Hop_Dong hd  " +
                   "WHERE hd.MaPhongTro = @MaPhong AND pdtp.TrangThai = N'Đã Đóng' AND pdtp.MaHopDong = hd.MaHopDong";
            ;
            this.panel_PhongChiTiet.Controls.Clear();
            ThongTinPhong(query, QUERY_DB_QLNT.TongPhongDaTraTien(), i);
        }

        private void HienThiPhongChuaDongTien()
        {
            x = 40;
            y = 180;
            KCX = 370 - 40;
            KCY = 390 - 100;
            int i = 1;
            query = "select hd.MaPhongTro, pdtp.TongTien, pdtp.TrangThai " +
                   "from PhieuDongTienPhong  pdtp, Hop_Dong hd  " +
                   "WHERE hd.MaPhongTro = @MaPhong AND pdtp.TrangThai = N'Chưa ĐÓng' AND pdtp.MaHopDong = hd.MaHopDong";
            ;
            this.panel_PhongChiTiet.Controls.Clear();
            ThongTinPhong(query, QUERY_DB_QLNT.TongPhongDaTraTien(), i);
        }
        //----------------------------------------------END------------------------------------------------------

        //----------------------------------------EVENT CBB TRẠNG THÁI PHÒNG----------------------------------------
        private void cbb_TrangThaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_TrangThaiPhong.Text == "1. Hiện thị phòng đang cho thuê")
            {
                if (A != null)
                {
                    HienThiPhongThue();
                }
            }
            if(cbb_TrangThaiPhong.Text == "2 . Hiển thị phòng trống")
            {
                if (A != null)
                {
                    HienThiPhongTrong();
                }
            }
            if(cbb_TrangThaiPhong.Text == "3. Hiển thị tất cả phòng")
            {
                if(A != null)
                {
                    HienThiTatCa();
                }
            }

        }

        private void cbb_TrangThaiPhieuThuTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_TrangThaiPhieuThuTien.SelectedIndex == 0)
            {
                if (A != null)
                {
                    HienThiPhongDaDongTien();
                }
            }
            if (cbb_TrangThaiPhieuThuTien.SelectedIndex == 1)
            {
                if (A != null)
                {
                    HienThiPhongChuaDongTien();
                }
            }
        }


        //------------------------------------------------------END-----------------------------------------------------
        //-----------------------------------------TẠO SỰ KIỆN CHO ĐỐI TƯỢNG CHƯA ĐC KHỞI TẠO----------------------------
        private void buttonClick(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            MessageBox.Show(current.Name);
        }

        private void buttonXem(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            int MaPhong = int.Parse(current.Name);
            Chi_Tiet_Phong_Tro CTPT = new Chi_Tiet_Phong_Tro(MaPhong);
            CTPT.Show();
        }

        private void btn_NguoiThue_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang DSKH = new DanhSachKhachHang();
            DSKH.Show();
        }

        private void cbb_NhaTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manha = int.Parse(cbb_NhaTro.SelectedValue.ToString());
            if(A != null)
            {
                HienThiTheoNhaTro(manha);
            }
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            DanhSachPhongTro LISTPT = new DanhSachPhongTro();
            LISTPT.Show();
        }
    }
    
}
