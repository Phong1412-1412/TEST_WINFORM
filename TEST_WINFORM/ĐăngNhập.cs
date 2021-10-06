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
    public partial class ĐăngNhập : Form
    {
        public ĐăngNhập()
        {
            InitializeComponent();
        }

        private bool check()
        {
            if(txt_MatKhau.Text ==""||txt_TenNguoiDung.Text=="")
            {
                MessageBox.Show("Tai khoan hoac mat khau khong duoc de trong!","Thông báo",MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        public static string KT = "";
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(check())
            {
                
               string name = txt_TenNguoiDung.Text; 
               int pass =int.Parse(txt_MatKhau.Text);
                KT = QUERY_DB_QLNT.KT_LogIn(name, pass);
                if (KT!="")
                {
                    GiaoDienMain GDM = new GiaoDienMain();
                    GDM.Show();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
                    txt_MatKhau.Clear();
                    txt_TenNguoiDung.Clear();
                }
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            Đăng_Ký_Chủ_Trọ DKCT = new Đăng_Ký_Chủ_Trọ();   
            DKCT.Show();
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}
