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

    public partial class ThemPhongTro : Form
    {
        private readonly Phong Phong;
        private readonly DanhSachPhongTro DSPT;
        public ThemPhongTro(Phong p)
        {
            InitializeComponent();
            Phong = p;
        }

        public ThemPhongTro(DanhSachPhongTro dspt)
        {
            InitializeComponent();
            DSPT = dspt;
        }

        int MaPhong;
        string HT;
        public ThemPhongTro(Phong p, int MP, string HienThi)
        {
            InitializeComponent();
            Phong = p;
            MaPhong = MP;
            HT = HienThi;
        }

        private void ThemPhongTro_Load(object sender, EventArgs e)
        {
            if(HT== "SuaPhong")
            {
                lbl_MaPhong.Text = MaPhong.ToString();
                btn_ChinhPT.Text = "Chỉnh sửa";
                QUERY_DB_QLNT.HienThiPhongChinhSua(MaPhong,txt_SoTang,txt_TienPhong,txt_TienDatCoc,txt_TienDien,txt_TienNuoc);
            }
            else
            {
                lbl_PhongTro.Text = "THÊM MỚI PHÒNG TRỌ:";
            }
            HienThiNhaTro();
        }

        private void btn_ChinhPT_Click(object sender, EventArgs e)
        {
            int SoTang = int.Parse(txt_SoTang.Text);
            int TienPhong = int.Parse(txt_TienPhong.Text);
            int TienCoc = int.Parse(txt_TienDatCoc.Text);
            int TienDien = int.Parse(txt_TienDien.Text);
            int TienNuoc = int.Parse(txt_TienNuoc.Text);
            int NhaTro = int.Parse(cbb_NhaTro.SelectedValue.ToString());
            
            if(HT == "SuaPhong")
            {
                Phong_Tro B = new Phong_Tro(MaPhong, NhaTro, SoTang, TienPhong, TienCoc, TienDien, TienNuoc);
                if (MessageBox.Show("Bạn có muốn cập nhật phòng không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUERY_DB_QLNT.CapNhatPhongTro(B);
                    Phong.HienThiTatCa();
                    DSPT.HienTHiListPhong();
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thêm phòng không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Phong_Tro A = new Phong_Tro(NhaTro,SoTang,TienPhong,TienCoc,TienDien,TienNuoc);
                    QUERY_DB_QLNT.ThemPhongTro(A);
                    DSPT.HienTHiListPhong();

                }    
            }
        }

        public void HienThiNhaTro()
        {
            QUERY_DB_QLNT.HienThiCBB("Select * from Nha_Tro", "MaNhaTro", "MaNhaTro", cbb_NhaTro);
           
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txt_SoTang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_TienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_TienDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_TienPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_TienNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}
