using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_WINFORM
{
    class Phieu_Dong_Tien_Phong
    {
        public Phieu_Dong_Tien_Phong(int maPhieu, int maHopDong, float tienDien, float tienNuoc, float tienPhong, string trangThai, string thang, float tongtien)
        {
            MaPhieu = maPhieu;
            MaHopDong = maHopDong;
            TienDien = tienDien;
            TienNuoc = tienNuoc;
            TienPhong = tienPhong;
            TrangThai = trangThai;
            Thang = thang;
            tongtien = (tienDien + tienNuoc + tienPhong);
            TongTien = tongtien;
        }

        public int MaPhieu { get; set; }
        public int MaHopDong { get; set; }
        public float TienDien { get; set; }
        public float TienNuoc { get; set; }
        public float TienPhong { get; set; }
        public string TrangThai { get; set; }
        public string Thang { get; set; }
        public float TongTien { get; set; }
    }
}
