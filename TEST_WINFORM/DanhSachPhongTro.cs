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
  
    public partial class DanhSachPhongTro : Form
    {
        private readonly Phong phong;
        public DanhSachPhongTro(Phong p)
        {
            InitializeComponent();
            phong = p;
        }


        public void HienThiTTPT()
        {
            
        }

        private void DanhSachPhongTro_Load(object sender, EventArgs e)
        {
            HienTHiListPhong();
        }
        int MaPhong = 0;

        public void HienTHiListPhong()
        {
            QUERY_DB_QLNT.HienThiListPhong(listV_DSPT);
        }

        private void listV_DSPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem Item in listV_DSPT.SelectedItems)
            {
                txt_MaPhongTro.Text = Item.SubItems[0].Text;
                txt_MaNhaTro.Text = Item.SubItems[1].Text;
                txt_SoTang.Text = Item.SubItems[2].Text;
                txt_GiaThue.Text = Item.SubItems[3].Text;
                txt_TienDatCoc.Text = Item.SubItems[4].Text;
                txt_TienDien.Text = Item.SubItems[5].Text;
                txt_TienNuoc.Text = Item.SubItems[6].Text;
                txt_TrangThai.Text = Item.SubItems[7].Text;
                txt_MaNguoiThue.Text = Item.SubItems[8].Text;
                MaPhong = int.Parse(Item.SubItems[0].Text);
            }
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_XemNguoiThue_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang DSKH = new DanhSachKhachHang();
            DSKH.Show();
        }

        private void btn_ThemPhongtro_Click(object sender, EventArgs e)
        {
            ThemPhongTro TPT = new ThemPhongTro(this);
            TPT.Show();
        }

        private void btn_SuaPhongTro_Click(object sender, EventArgs e)
        {
            if(MaPhong !=0)
            {
                ThemPhongTro TPT = new ThemPhongTro(phong, MaPhong, "SuaPhong");
                TPT.Show();
            }
            else
            {
                MessageBox.Show("Vui Long chon phong muốn update!","Thông báo",MessageBoxButtons.OK);
            }
        }

        private void btn_XoaPhongTro_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa phòng này không","Cảnh Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                QUERY_DB_QLNT.XoaPhongTro_HD(MaPhong);
                HienTHiListPhong();
            }    
            
        }

        private void txt_SoTang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_GiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_TienDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_TienNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_TienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}
