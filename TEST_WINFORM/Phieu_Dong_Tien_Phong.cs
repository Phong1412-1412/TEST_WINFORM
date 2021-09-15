using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_WINFORM
{
    class Phieu_Dong_Tien_Phong
    {
        public Phieu_Dong_Tien_Phong(int maHopDong, double tienDien, double tienNuoc, double tienPhong, string trangThai, string thang)
        {
            MaHopDong = maHopDong;
            TienDien = tienDien;
            TienNuoc = tienNuoc;
            TienPhong = tienPhong;
            TrangThai = trangThai;
            Thang = thang;
            double tongtien = (tienDien + tienNuoc + tienPhong);
          
        }

        public int MaPhieu { get; set; }
        public int MaHopDong { get; set; }
        public double TienDien { get; set; }
        public double TienNuoc { get; set; }
        public double TienPhong { get; set; }
        public string TrangThai { get; set; }
        public string Thang { get; set; }
        public double TongTien { get; set; }
    }
}
