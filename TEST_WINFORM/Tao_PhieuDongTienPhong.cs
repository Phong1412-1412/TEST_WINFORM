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
    public partial class Tao_PhieuDongTienPhong : Form
    {
        private readonly Chi_Tiet_Phong_Tro CTPT;
        int MaPhong;
        double TienDien;
        double TienNuoc;
        double TienPhong;
        string TenNguoiThe;
        int SoDien;
        int KhoiNuoc;
        int MaHopDong;
        public Tao_PhieuDongTienPhong()
        {
            InitializeComponent();
        }

        private void Tao_PhieuDongTienPhong_Load(object sender, EventArgs e)
        {
          
            txt_MaNhaTro.Text = MaPhong.ToString();
            txt_TenNguoiThu.Text = TenNguoiThe;
            txt_TienDien.Text = TienDien.ToString();
            txt_TienNuoc.Text = TienNuoc.ToString();
            txt_TienPhong.Text = TienPhong.ToString();
                SoDien = int.Parse(txt_SoDien.Text);
                KhoiNuoc = int.Parse(txt_KhoiNuoc.Text);
        }

        private void TongTienPhong() {
            if (txt_SoDien.Text != "" && txt_KhoiNuoc.Text != "") {
                SoDien = int.Parse(txt_SoDien.Text);
                KhoiNuoc = int.Parse(txt_KhoiNuoc.Text);
                txt_TongTien.Text = (TienPhong + (TienDien * SoDien) + (TienNuoc * KhoiNuoc)).ToString();
            }
           
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon huy them phieu thu khong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        public Tao_PhieuDongTienPhong(Chi_Tiet_Phong_Tro ctpt,int MP, string Ten_NT, int TD, int TN, int TP) {
            MaPhong = MP;
            TenNguoiThe = Ten_NT;
            TienDien = TD;
            TienNuoc = TN;
            TienPhong = TP;
            MaHopDong = QUERY_DB_QLNT.MaHopDong_PT(MaPhong);
            CTPT = ctpt;
            InitializeComponent();
        }

        private void txt_SoDien_TextChanged(object sender, EventArgs e)
        {
            TongTienPhong();
        }

        private void txt_KhoiNuoc_TextChanged(object sender, EventArgs e)
        {
            TongTienPhong();
        }

        private void btn_ThemPT_Click(object sender, EventArgs e)
        {
            if (txt_SoDien.Text != "" && txt_KhoiNuoc.Text != "" && txt_Thang.Text != "")
            {
                double TD = TienDien * SoDien;
                double TN = TienNuoc * KhoiNuoc;
                Phieu_Dong_Tien_Phong A = new Phieu_Dong_Tien_Phong(MaHopDong,TD,TN,TienPhong,cbb_TinhTrang.Text,txt_Thang.Text);
                QUERY_DB_QLNT.ThemPhieuThuTienPhong(A);
                CTPT.HienThiDS_PHieuDongTienPhong();
            }
        }
    }
}
