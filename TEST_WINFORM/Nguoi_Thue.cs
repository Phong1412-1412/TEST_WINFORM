using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_WINFORM
{
    class Nguoi_Thue
    {
        public Nguoi_Thue(string tenNguoiThue, string sDT, string cMND, int gioiTinh, DateTime ngaySinh, string diaChi)
        {
            TenNguoiThue = tenNguoiThue;
            SDT = sDT;
            CMND = cMND;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }

       public string TenNguoiThue { get; set; }
       public string SDT { get; set; }
       public string CMND { get; set; }
       public int GioiTinh { get; set; }
       public DateTime NgaySinh { get; set; }
       public string DiaChi { get; set; }
    }
}
