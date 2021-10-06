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
    public partial class Chi_Tiet_Phong_Tro : Form
    {
        public Chi_Tiet_Phong_Tro()
        {
            InitializeComponent();
        }
        int MP = 0;
        int MaPhieu;
        string TenNguoiThue;
        int TienDien;
        int TienNuoc;
        int TienPhong;
        public Chi_Tiet_Phong_Tro(int MaPhong)
        {
            MP = MaPhong;
           
            InitializeComponent();
        }
        private void Chi_Tiet_Phong_Tro_Load(object sender, EventArgs e)
        {
            lbl_CTPTTP_MP.Text += MP.ToString();
            lbl_MaPhongCT.Text += MP.ToString();
            HienThiDS_PHieuDongTienPhong();
            HienThiTTPT();
        }

        public void HienThiDS_PHieuDongTienPhong()
        {
            string query = "select *from dbo.HienThiDS_PHieuDongTienPhong ('"+MP+"')";
            QUERY_DB_QLNT.HienThiDGV(query,dgv_DS_PhieuThiTien);
        }

        public void HienThiTTPT()
        {
            string query = "select *from dbo.HienTHiThongTinPhong ('"+MP+"') ";
            QUERY_DB_QLNT.HienThiPhongTheoMa(query,MP, txt_MaNhaTro,txt_TenNguoiThu,txt_SoTang,txt_TrangThai,txt_TienDatCoc,txt_TienPhong,txt_TienDien,txt_TienNuoc);
        }

        private void dgv_DS_PhieuThiTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
          
            if(vt < dgv_DS_PhieuThiTien.Rows.Count - 1 && vt >=0 )
            {
                DataGridViewRow Chon = this.dgv_DS_PhieuThiTien.Rows[vt];
                txt_MaPhieu.Text = Chon.Cells[0].Value.ToString();
                txt_MaHopDong.Text = Chon.Cells[1].Value.ToString();
                txt_TrangThaiPT.Text = Chon.Cells[2].Value.ToString();
                txt_TienDatCoc.Text = Chon.Cells[3].Value.ToString();
                txt_TienPhongPT.Text = Chon.Cells[4].Value.ToString();
                txt_TienDienPT.Text = Chon.Cells[5].Value.ToString();
                txt_TienNuocPT.Text = Chon.Cells[6].Value.ToString();
                txt_TongTienPT.Text = Chon.Cells[7].Value.ToString();
                txt_ThangPT.Text = Chon.Cells[8].Value.ToString();
                MaPhieu = int.Parse(Chon.Cells[0].Value.ToString());
            }
           
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_InPT_Click(object sender, EventArgs e)
        {
            if(MP != 0) 
            {
                Report_Phie_Thu_Tien_Phong inPTT = new Report_Phie_Thu_Tien_Phong(MaPhieu);
                inPTT.Show();
            }
            else
            {
                MessageBox.Show("Vui long chon phieu thu tien muon in","Thong bao");
            }
           
        }

        private void btn_ThemPT_Click(object sender, EventArgs e)
        {
            TienDien = int.Parse(txt_TienDien.Text);
            TienNuoc = int.Parse(txt_TienNuoc.Text);
            TienPhong = int.Parse(txt_TienPhong.Text);
            TenNguoiThue = txt_TenNguoiThu.Text;
            Tao_PhieuDongTienPhong Tao_PDTP = new Tao_PhieuDongTienPhong(this,MP,TenNguoiThue,TienDien,TienNuoc,TienPhong);
            Tao_PDTP.Show();
        }

        private void btn_ChinhPT_Click(object sender, EventArgs e)
        {
            if(txt_TrangThaiPT.Text == "Đã đóng" || txt_TrangThaiPT.Text == "Chưa đóng")
            {
                if (MessageBox.Show("Bạn có chắc muốn cấp nhập k???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUERY_DB_QLNT.CapNhat_PDTP(txt_TrangThaiPT.Text, MaPhieu);
                    this.HienThiDS_PHieuDongTienPhong();
                }    
               
            }
            else
            {
                MessageBox.Show("Trạng thái chỉ chó thể là Đã đóng hoặc Chưa Đóng","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_TrangThaiPT.Text = "";
            }
        }

        private void btn_XoaPT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn Xóa phiếu thu này k???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QUERY_DB_QLNT.Xoa_PDTP( MaPhieu);
                this.HienThiDS_PHieuDongTienPhong();
            }
        }

        private void btn_XemNguoiThue_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang DSKH = new DanhSachKhachHang();
            DSKH.Show();
        }

        private void txt_ThangPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TrangThaiPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
