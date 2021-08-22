using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_WINFORM
{
    class Phong_Tro
    {
        public Phong_Tro(int maPhongTro, int maNhaTro, int soTang, float giaThue, float tienDatCoc, float tienDien, float tienNuoc, string trangThai, int maNguoiThu)
        {
            MaPhongTro = maPhongTro;
            MaNhaTro = maNhaTro;
            SoTang = soTang;
            GiaThue = giaThue;
            TienDatCoc = tienDatCoc;
            TienDien = tienDien;
            TienNuoc = tienNuoc;
            TrangThai = trangThai;
            MaNguoiThu = maNguoiThu;
        }

        public Phong_Tro()
        {
            MaPhongTro = 1;
            MaNhaTro = 1;
            SoTang = 1;
            GiaThue = 1;
            TienDatCoc = 1;
            TienDien = 1;
            TienNuoc = 1;
            TrangThai = "";
            MaNguoiThu = 1;
        }
        public int MaPhongTro { get; set; }
        public int MaNhaTro { get; set; }
        public int SoTang { get; set; }
        public float GiaThue { get; set; }
        public float TienDatCoc { get; set; }
        public float TienDien { get; set; }
        public float TienNuoc { get; set; }
        public string TrangThai { get; set; }
        public int MaNguoiThu { get; set; }
    }
}
