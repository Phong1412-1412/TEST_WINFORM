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
        public DanhSachPhongTro()
        {
            InitializeComponent();
        }


        public void HienThiTTPT()
        {
            
        }

        private void DanhSachPhongTro_Load(object sender, EventArgs e)
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
            }
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
