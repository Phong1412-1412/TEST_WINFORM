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
    public partial class Them_Nha_Tro : Form
    {
        private readonly Phong phong;
        public Them_Nha_Tro(Phong p)
        {
            phong = p;
            InitializeComponent();
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void HienThi_NhaTro()
        {
            QUERY_DB_QLNT.HienThiCBB("Select MaChuTro, TenChuTro from Chu_Tro","MaChuTro","TenChuTro",cbb_TenChuTro);
        }

        private void Them_Nha_Tro_Load(object sender, EventArgs e)
        {
            HienThi_NhaTro();
        }

        private void btn_XacNhanThemNT_Click(object sender, EventArgs e)
        {
           if(txt_DiaChiNhaTro.Text != "")
            {
                QUERY_DB_QLNT.Them_Nha_tro(int.Parse(cbb_TenChuTro.SelectedValue.ToString()), txt_DiaChiNhaTro.Text);
                phong.HienThi_NhaTro();
            }
           else
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà trọ!!!","Thông Báo");
                txt_DiaChiNhaTro.Focus();
            }
        }
    }
}
