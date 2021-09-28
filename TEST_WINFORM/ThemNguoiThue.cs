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
    public partial class ThemNguoiThue : Form
    {
        private readonly DanhSachKhachHang danhSachKhachHang;
        private readonly ThemKhach ThemKhach;
        public ThemNguoiThue(DanhSachKhachHang dskh)
        {
            InitializeComponent();
            danhSachKhachHang = dskh;
        }
        
        public ThemNguoiThue(ThemKhach Tk)
        {
            InitializeComponent();
            ThemKhach = Tk;
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon huy them nguoi thue khong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }
        
        private void clear()
        {
            txt_TenNguoiThue.Clear();
            txt_SDT.Clear();
            txt_CMND.Clear();
            txt_GioiTinh.Clear();
            txt_DiaChi.Clear();
            dtime_NgaySinh.Value = DateTime.Now;
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            clear();
        }
        private bool KiemTraThongTinNhap()
        {
            if(string.IsNullOrEmpty(txt_TenNguoiThue.Text) || string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_CMND.Text) || string.IsNullOrEmpty(txt_DiaChi.Text)|| string.IsNullOrEmpty(txt_GioiTinh.Text))
            {
                
                return false;
            }
            return true;
        }
        private void btn_XacNhanThemNT_Click(object sender, EventArgs e)
        {
            string TenNguoiThue = txt_TenNguoiThue.Text;
            string SDT = txt_SDT.Text;
            string CMND = txt_CMND.Text;
            int GioiTinh = 0;
                GioiTinh = int.Parse(txt_GioiTinh.Text);
            DateTime NgaySinh = dtime_NgaySinh.Value;
            String DiaChi = txt_DiaChi.Text;
            Nguoi_Thue A = new Nguoi_Thue(TenNguoiThue,SDT,CMND,GioiTinh,NgaySinh,DiaChi);
            if(GioiTinh <=0 || GioiTinh >= 3)
            {
                MessageBox.Show("Vui long nhap gioi tinh trong gio han","Thong bao");
                txt_GioiTinh.Clear();
                txt_GioiTinh.Focus();
            }
            else
            {
                if(KiemTraThongTinNhap() == true)
                {
                    QUERY_DB_QLNT.ThemMoiNguoiThue(A);
                    danhSachKhachHang.HienThiListView();
                    ThemKhach.HienThi_TenNT();
                    clear();
                }
                else
                {
                    MessageBox.Show("Vui long nhap day du thong tin", "Thong Bao");
                }
            }
                
        }

        private void txt_TenNguoiThue_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_GioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '1' && e.KeyChar <= '3'|| e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}
