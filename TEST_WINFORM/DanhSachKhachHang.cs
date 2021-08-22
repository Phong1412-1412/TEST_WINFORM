using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_WINFORM
{
    public partial class DanhSachKhachHang : Form
    {
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            HienThiListView();
           
        }

        public void HienThiListView()
        {
            if(listV_DSKH.Columns != null)
            {
                listV_DSKH.Clear();
                QUERY_DB_QLNT.HienThiListV(listV_DSKH);
            }
          
        }

     
        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listV_DSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listV_DSKH.SelectedItems)
            {
                txt_MaNguoiThue.Text = items.SubItems[0].Text;
                txt_TenNguoiThue.Text = items.SubItems[1].Text;
                txt_SDT.Text = items.SubItems[2].Text;
                txt_CMND.Text = items.SubItems[3].Text;
               // txt_GioiTinh.Text = items.SubItems[4].Text;
                txt_DiaChi.Text = items.SubItems[6].Text;
                dtime_NgaySinh.Value = DateTime.ParseExact(items.SubItems[5].Text, "d/M/yyyy", CultureInfo.InvariantCulture);
                string GT = items.SubItems[4].Text.Trim();
                    if(GT == "Nam")
                    {
                        cbb_GioiTinh.SelectedIndex = 0;
                    }
                     else if(GT =="Nữ")
                    {
                        cbb_GioiTinh.SelectedIndex = 1;
                    }
                    else
                    {
                        cbb_GioiTinh.SelectedIndex = 2;
                    }
            }
        }

        private void btn_ThemNguoiThue_Click(object sender, EventArgs e)
        {
            ThemNguoiThue tnt = new ThemNguoiThue(this);
            tnt.Show();
        }

        private void btn_XoaNguoiThue_Click(object sender, EventArgs e)
        {
            int MaNguoiThue = int.Parse(txt_MaNguoiThue.Text);
            string TenNguoiThue = txt_TenNguoiThue.Text;
            if (MaNguoiThue != 0)
            {
                if (MessageBox.Show($"Ban co chac muon xoa: {TenNguoiThue} ra khoi danh sach nguoi thue nay???", "CanhBao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    QUERY_DB_QLNT.XoaNguoiThue(MaNguoiThue);
                    HienThiListView();
                }
            }
            else
            {
                MessageBox.Show("Vui long chon nguoi thue muon xoa!!!","Thong Bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
          
        }
        private bool KiemTraThongTinNhap()
        {
            if (string.IsNullOrEmpty(txt_TenNguoiThue.Text) || string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_CMND.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) )
            {

                return false;
            }
            return true;
        }

        private void btn_SuaNguoiThue_Click(object sender, EventArgs e)
        {
            int MaNguoiThue = int.Parse(txt_MaNguoiThue.Text);
            if (MaNguoiThue != 0)
            {
                string TenNguoiThue = txt_TenNguoiThue.Text;
                string SDT = txt_SDT.Text;
                string CMND = txt_CMND.Text;
                int GioiTinh = 0;
                if(cbb_GioiTinh.SelectedIndex == 0)
                {
                    GioiTinh = 1;
                }
                if (cbb_GioiTinh.SelectedIndex == 1)
                {
                    GioiTinh = 2;
                }
                if (cbb_GioiTinh.SelectedIndex == 2)
                {
                    GioiTinh = 3;
                }
                
                DateTime NgaySinh = dtime_NgaySinh.Value;
                String DiaChi = txt_DiaChi.Text;
                Nguoi_Thue A = new Nguoi_Thue(TenNguoiThue, SDT, CMND, GioiTinh, NgaySinh, DiaChi);
                if (GioiTinh <= 0 || GioiTinh > 3)
                {
                    MessageBox.Show("Vui long nhap gioi tinh trong gio han", "Thong bao");
                
                }
                else
                {
                    if (KiemTraThongTinNhap() == true)
                    {
                        if(MessageBox.Show($"Ban co chac muon cap nhat nguoi thue co ten {TenNguoiThue} trong danh sach khong? ","Thong bao",MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            QUERY_DB_QLNT.CapNhatNguoiThue(A, MaNguoiThue);
                            HienThiListView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui long nhap day du thong tin", "Thong Bao");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui long chon nguoi thue muon Cap nhat!!!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
         
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txt_NgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_XemPhongThue_Click(object sender, EventArgs e)
        {
            int MaNguoiThue = int.Parse(txt_MaNguoiThue.Text);
            if (MaNguoiThue != 0)
            {
                int MaPhong = QUERY_DB_QLNT.LayMaPhong(MaNguoiThue);
                Chi_Tiet_Phong_Tro CTPT = new Chi_Tiet_Phong_Tro(MaPhong);
                CTPT.Show();
            }
            else
            {
                MessageBox.Show("Vui long chon nguoi thue muon xem!!!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
