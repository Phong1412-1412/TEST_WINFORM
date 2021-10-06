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
    public partial class Đăng_Ký_Chủ_Trọ : Form
    {
        public Đăng_Ký_Chủ_Trọ()
        {
            InitializeComponent();
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_ThemNguoiThue_Click(object sender, EventArgs e)
        {
            if(txt_CMND.Text!=""&&txt_DiaChi.Text!="" && txt_MatKhau.Text!="" && txt_TenNguoiDung.Text!="")
            {
                string Ten = txt_TenNguoiDung.Text;
                string diachi = txt_DiaChi.Text;
                string cmnd = txt_CMND.Text;
                int pass = int.Parse(txt_MatKhau.Text);

                QUERY_DB_QLNT.ĐangKy_ChuTro(Ten, cmnd,diachi,pass);
            }    
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo");
            }
        }
    }
}
