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
   
    public partial class ThemKhach : Form
    {
        private readonly Phong phong;
        int MaPhong;
        public ThemKhach(Phong p, int MP)
        {
            InitializeComponent();
            phong = p;
            MaPhong = MP;
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void HienThi_TenNT()
        {
            QUERY_DB_QLNT.HienThiCBB("Select MaNguoiThue, TenNguoiThue from Nguoi_Thue", "MaNguoiThue", "TenNguoiThue", cbb_TenNguoiThue);
            
        }

        private void ThemKhach_Load(object sender, EventArgs e)
        {
            txt_MaPhong.Text = MaPhong.ToString();
            txt_MaPhong.Enabled = false;
            HienThi_TenNT();

        }

        private void btn_ThemNguoiThueNhanh_Click(object sender, EventArgs e)
        {
            ThemNguoiThue TnT = new ThemNguoiThue(this);
            TnT.Show();
           
        }
    }
}
