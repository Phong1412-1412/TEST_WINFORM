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
        string HienThi;
        public ThemKhach(Phong p, int MP, string ht)
        {
            InitializeComponent();
            phong = p;
            MaPhong = MP;
            HienThi = ht;
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void HienThi_TenNT()
        {
            QUERY_DB_QLNT.HienThiCBB("Select MaNguoiThue, TenNguoiThue from Nguoi_Thue", "MaNguoiThue", "TenNguoiThue", cbb_TenNguoiThue);
            
        }

        public void HienThi_ChuTro()
        {
            QUERY_DB_QLNT.HienThiCBB("select ct.MachuTro, ct.TenChuTro from Phong_Tro pt, Chu_Tro ct, Nha_Tro ntr where pt.MaNhaTro = ntr.MaNhaTro AND ntr.MaChuTro = ct.MaChuTro AND pt.MaPhongTro = '"+MaPhong+"'","MaChuTro","TenChuTro",cbb_TroCho);
        }

        private void ThemKhach_Load(object sender, EventArgs e)
        {
            if(HienThi =="SuaHD") 
            {
                lbl_HienThiHD.Text = "Chỉnh sửa hợp đồng thuê phòng";
                btn_TaoHopDong.Text = "Xác nhận chỉnh sửa hợp đồng";
                lbl_TenNguoiThue.Visible = false;
                cbb_TenNguoiThue.Enabled = false;
                btn_ThemNguoiThueNhanh.Enabled = false;
                txt_TenNTMacDinh.Enabled = false;

                QUERY_DB_QLNT.HienThiTTHD(MaPhong,txt_TenNTMacDinh,dateTime_NgayBD,dateTime_NgayKT,txt_TienCoc);
            }
            else
            {
                txt_TenNTMacDinh.Visible = false;
            }
            txt_MaPhong.Text = MaPhong.ToString();
            txt_MaPhong.Enabled = false;
            HienThi_TenNT();
            HienThi_ChuTro();
           

        }

        private void btn_ThemNguoiThueNhanh_Click(object sender, EventArgs e)
        {
            ThemNguoiThue TnT = new ThemNguoiThue(this,"THEMHOPDONG");
            TnT.Show();
           
        }

        private void btn_TaoHopDong_Click(object sender, EventArgs e)
        {
            int MaPhong = int.Parse(txt_MaPhong.Text);
            int MaChuTro = (int)cbb_TroCho.SelectedValue;
            int MaKhach = int.Parse(cbb_TenNguoiThue.SelectedValue.ToString());
            DateTime NgayBD = dateTime_NgayBD.Value;
            DateTime NgayKT = dateTime_NgayKT.Value;
            int TienCoc = int.Parse(txt_TienCoc.Text);
            if (HienThi == "ThemHD")
            {
                if (MessageBox.Show("Bạn có muốn tạo hợp đồng này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUERY_DB_QLNT.ThemHopDong(MaChuTro, MaKhach, MaPhong, NgayBD, NgayKT, TienCoc);
                    phong.HienThiTatCa();
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn cấp nhật không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUERY_DB_QLNT.CapNhatHD(MaChuTro,MaPhong,NgayBD,NgayKT,TienCoc);
                    phong.HienThiTatCa();
                }
            }
            
        }
    }
}
