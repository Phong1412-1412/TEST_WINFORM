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
            string query = " SELECT pdtp.MaPhieu as N'Mã phiếu',  hd.MaHopDong as N'Mã hợp đồng', pdtp.TrangThai as N'Trạng thái', pt.TienDatCoc as N'Tiền đặt cọc', pt.GiaThue as N'Giá thuê', pt.TienDien as N'Tiền điện',pt.TienNuoc as N'Tiền nước', pdtp.TongTien as N'Tổng tiền', pdtp.Thang as N'Tháng' " +
                           " FROM Phong_Tro pt, Hop_Dong hd, phieuDongTienPhong pdtp " +
                            " WHERE pt.MaPhongTro = hd.MaPhongTro AND hd.MaHopDong = pdtp.MaHopDong AND pt.MaPhongTro = "+MP+" ";
            QUERY_DB_QLNT.HienThiDGV(query,dgv_DS_PhieuThiTien);
        }

        public void HienThiTTPT()
        {
            string query = " SELECT pt.MaNhaTro as N'Mã nhà trọ', nt.TenNguoiThue as N'Tên người thuê', pt.SoTang as N'Số tầng', pt.TrangThai as N'Trạng thái', pt.TienDatCoc as N'Tiền đặt cọc', pt.GiaThue as N'Giá thuê', pt.TienDien as N'Tiền điện',pt.TienNuoc as N'Tiền nước' " +
                           " FROM Phong_Tro pt, Hop_Dong hd, Nguoi_Thue nt " +
                           " WHERE pt.MaPhongTro = hd.MaPhongTro AND hd.MaNguoiThue = nt.MaNguoiThue AND pt.MaPhongTro = @MaPhongTro ";
            QUERY_DB_QLNT.HienThiPhongTheoMa(query,MP, txt_MaNhaTro,txt_TenNguoiThu,txt_SoTang,txt_TrangThai,txt_TienDatCoc,txt_TienPhong,txt_TienDien,txt_TienNuoc);
        }

        private void dgv_DS_PhieuThiTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
          
            if(vt <= dgv_DS_PhieuThiTien.Rows.Count && vt >=0 )
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
    }
}
