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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }
        //------------------------------------------HIỂN THỊ DỮ LIỆU QUA EVENT CLICK-----------------------------------------
        private void btn_TongPhong_Click(object sender, EventArgs e)
        {
            string query_PPDang_Thue = "SELECT MaPhongTro as N'Mã phòng trọ', MaNhaTro as N'Mã Nhà trọ', MaNguoiThue as N'Mã người thuê', SoTang as N'Số tầng', GiaThue as N'Giá thuê', TienDatCoc as N'Tiền đặt cọc', TienDien as N'Tiền điện', TienNuoc as N'Tiền nước', TrangThai as N'Trạng thái' " +
                         " FROM Phong_Tro ";       
            QUERY_DB_QLNT.HienThiDGV(query_PPDang_Thue, dgvPhong);
        }

        private void btn_PhongTrong_Click(object sender, EventArgs e)
        {
            string query_PPDang_Thue = "SELECT MaPhongTro as N'Mã phòng trọ', MaNhaTro as N'Mã Nhà trọ', MaNguoiThue as N'Mã người thuê', SoTang as N'Số tầng', GiaThue as N'Giá thuê', TienDatCoc as N'Tiền đặt cọc', TienDien as N'Tiền điện', TienNuoc as N'Tiền nước', TrangThai as N'Trạng thái' " +
                         " FROM Phong_Tro " + " WHERE TrangThai = N'Trống'";
            QUERY_DB_QLNT.HienThiDGV(query_PPDang_Thue, dgvPhong);
        }

        private void btn_PhongThue_Click(object sender, EventArgs e)
        {
            string query_PPDang_Thue = "SELECT MaPhongTro as N'Mã phòng trọ', MaNhaTro as N'Mã Nhà trọ', MaNguoiThue as N'Mã người thuê', SoTang as N'Số tầng', GiaThue as N'Giá thuê', TienDatCoc as N'Tiền đặt cọc', TienDien as N'Tiền điện', TienNuoc as N'Tiền nước', TrangThai as N'Trạng thái' " +
                         " FROM Phong_Tro " + " WHERE TrangThai = N'Đã cho thuê'";
            QUERY_DB_QLNT.HienThiDGV(query_PPDang_Thue, dgvPhong);
        }
        //-----------------------------------------------END------------------------------------------------
        private void HOME_Load(object sender, EventArgs e)
        {
            string qr_DongTienTre = "SELECT * " + " FROM PhieuDongTienPhong ";
            QUERY_DB_QLNT.HienThiDGV(qr_DongTienTre, dgvNoTien);
            string query_PPDang_Thue = "SELECT MaPhongTro as N'Mã phòng trọ', MaNhaTro as N'Mã Nhà trọ', MaNguoiThue as N'Mã người thuê', SoTang as N'Số tầng', GiaThue as N'Giá thuê', TienDatCoc as N'Tiền đặt cọc', TienDien as N'Tiền điện', TienNuoc as N'Tiền nước', TrangThai as N'Trạng thái' " +
                         " FROM Phong_Tro ";
            QUERY_DB_QLNT.HienThiDGV(query_PPDang_Thue, dgvPhong);
            btn_TongPhong.Text += QUERY_DB_QLNT.TongPhongINT().ToString();
            btn_PhongTrong.Text += QUERY_DB_QLNT.TongPhongTRONG();
            btn_PhongThue.Text += QUERY_DB_QLNT.TongPhongDaChoThue();
            HienThiDoanhThu();
        }
        //-----------------------------------------------END------------------------------------------------
        //----------------------------------------HIỂN THỊ DOANH THU---------------------------------
        private void HienThiDoanhThu()
        {

            string query = "SELECT Thang, Sum(TongTien) as N'Tổng doanh thu'" +
                            " FROM PHieuDongTienPhong "+
                            " WHERE TrangThai = N'Đã đóng' " +
                            " GROUP BY Thang";
            QUERY_DB_QLNT.HienThiChart(query, chart_DoanhThu);
            chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart_DoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tiền/VND";

            chart_DoanhThu.Series["chartDoanhThu"].XValueMember = "Thang";
            chart_DoanhThu.Series["chartDoanhThu"].YValueMembers = "Tổng doanh thu";
        }
        //-----------------------------------------------END------------------------------------------------
    }
}
