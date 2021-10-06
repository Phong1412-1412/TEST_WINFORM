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
    public partial class ChiSoDien : Form
    {
        public ChiSoDien()
        {
            InitializeComponent();
        }
        private void LayNha()
        {
            QUERY_DB_QLNT.HienThiCBB("SELECT * FROM Nha_Tro", "MaNhaTro", "DiChia", cbNha);
        }
        private void LayTrangThai()
        {
            QUERY_DB_QLNT.HienThiCBB("select TrangThai from Phong_Tro Group by TrangThai", "MaPhongTro", "TrangThai", cbTrangThai);
        }
        private void LayThongTinPhong()
        {
            string query = "select DiChia as N'Nhà' , MaPhongTro as N'Phòng' , TienDien as N'Tiền điện' " +
                           " from Nha_Tro a, Phong_Tro b" +
                          "  where a.MaNhaTro = b.MaNhaTro";
            QUERY_DB_QLNT.HienThiDGV(query, dgvPhong);

        }

        private void ChiSoDien_Load(object sender, EventArgs e)
        {
            LayThongTinPhong();
            
        }

        private void ChiSoDien_Shown(object sender, EventArgs e)
        {
           
            LayNha();
            LayTrangThai();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nha = cbNha.Text.ToString();
            string trangthai = cbTrangThai.Text.ToString();
            string query = "select nt.DiChia as N'Nhà trọ', pt.MaPhongTro as N'Số phòng', pt.TienDien as N'Tiền điện' " +
                " from Nha_Tro nt , Phong_Tro pt" +
                " where nt.MaNhaTro = pt.MaNhaTro and" +
                " nt.DiChia like  N'" + nha + "' and"+
                " pt.TrangThai like N'" + trangthai + "'"
                ;
            QUERY_DB_QLNT.HienThiDGV(query, dgvPhong);
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt == -1)
            {
                MessageBox.Show("Vui long chon dung dong......", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow dongchon = this.dgvPhong.Rows[vt];
              
                txtCSC.Text = dongchon.Cells[2].Value.ToString();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vt = dgvPhong.CurrentRow.Index;
            DataGridViewRow dongchon = dgvPhong.Rows[vt];
            int id = Convert.ToInt32(dongchon.Cells[1].Value);
            int tienDien =int.Parse(txtCSM.Text);
            QUERY_DB_QLNT.CapNhatGiaDien(tienDien, id);
            LayThongTinPhong();
            txtCSM.Text = "";

        }

        private void txtCSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
   
}
