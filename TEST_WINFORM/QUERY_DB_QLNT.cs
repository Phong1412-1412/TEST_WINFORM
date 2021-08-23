
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TEST_WINFORM
{

    class QUERY_DB_QLNT
    {
        // Hàm kết nối CSDL
        public static SqlConnection connection()
        {
            string strSql = @"Data Source=LAPTOP-C9IT8VA3\SQLEXPRESS;Initial Catalog=QL_NhaTro;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strSql);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MySql connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        // Hàm Hiển thị thông tin phòng chi tiết
        private static int i = 1;
        /* public static void HienThiPhong(Label MP, Label TrangThai, Label Gia,string qr)
         {
             string query = qr;

             string trangthai = ""; string ma = ""; string gia = "";
             //string tt = "";
             SqlConnection conn = connection();
             SqlCommand cmd = new SqlCommand(query, conn);
             SqlParameter prm = new SqlParameter();
             prm.ParameterName = "@MaPhongTro";
             prm.Value = i;
             cmd.Parameters.Add(prm);
             SqlDataReader dtread = cmd.ExecuteReader();
             if (dtread.Read())
             {
                 ma = dtread[0].ToString();
                 trangthai = dtread[2].ToString();
                 gia = dtread[1].ToString();
                 TrangThai.Text += trangthai;
                 MP.Text += ma;
                 Gia.Text += gia;   
                 i++;
                 if (i > TongPhongINT())
                 {
                     i = 1;
                 }

             }


         }*/
        // Lấy tổng số phòng
        public static void TongPhong(Label Tong)
        {
            string qr = "select count(pt.MaNhaTro) as Tong " +
                        " from Phong_Tro as pt ";

            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qr, conn);
            Tong.Text += cmd.ExecuteScalar().ToString();
        }

        public static int TongPhongINT()
        {
            int x;
            string qr = "select count(pt.MaNhaTro) as Tong " +
                        " from Phong_Tro as pt ";

            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qr, conn);
            x = (int)cmd.ExecuteScalar();
            return x;
        }
        //-----------------------------HÀM DÙNG ĐỂ HIỂN THỊ PHÒNG THEO YC---------------------------------------
        public static void HienThiPhong_YC(string qr, Label MP, Label TrangThai, Label Gia, Button Tra, Button Sua, Button Xem, Panel Phong)
        {
            // Kiếm tra i có vượt quá số phòng hay không nếu vượt qua thì ta gán i = 1 và gọi lại hàm(Đệ quy)
            if (i > TongPhongINT())
            {
                i = 1;
                HienThiPhong_YC(qr, MP, TrangThai, Gia, Tra, Sua, Xem, Phong);
            }

            // nếu i bé hơn tổng số phòng thì thực hiện đoạn code dưới
            else
            {
                string sql = qr;
                SqlConnection conn = connection();
                SqlParameter pram = new SqlParameter();
                pram.ParameterName = "@MaPhong";
                pram.Value = i;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(pram);
                SqlDataReader dataread = cmd.ExecuteReader();
                if (i <= TongPhongINT())
                {
                    // nếu có tồn tại một nào đó hàng thì thực hiện gán và tăng i lên 1 đơn vị
                    if (dataread.HasRows)
                    {
                        dataread.Read();
                        string tt = dataread[2].ToString().Trim();
                        MP.Name = dataread[0].ToString();
                        Tra.Name = dataread[0].ToString();
                        Xem.Name = dataread[0].ToString();
                        if (tt == "Trống")
                        {
                            Sua.Visible = false;
                            Xem.Visible = false;
                            //------------------------------
                            Phong.BackColor = System.Drawing.SystemColors.ControlDark;
                            Tra.AutoSize = true;
                            Tra.BackColor = System.Drawing.Color.DarkCyan;
                            Tra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            Tra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                            Tra.Size = new System.Drawing.Size(89, 25);
                            Tra.TabIndex = 8;
                            Tra.Text = "Thêm khách";
                            Tra.UseVisualStyleBackColor = false;
                                                  //--------------------------------
                            MP.Text += dataread[0].ToString();
                            Gia.Text += dataread[1].ToString() + " VND";
                            TrangThai.Text += dataread[2].ToString();  
                        }
                        else
                        {
                            MP.Text += dataread[0].ToString();
                            Gia.Text += dataread[1].ToString() + " VND";
                            TrangThai.Text += dataread[2].ToString();   
                        }                
                        i++;
                    }
                    // nếu không có dữ liệu thì ta tăng i lên 1 đơn vị và gọi lại hàm(đệ quy)
                    else
                    {
                        i++;
                        HienThiPhong_YC(qr, MP, TrangThai, Gia, Tra, Sua, Xem, Phong);
                    }
                }
            }

        }


        //---------------------------------------------------------END-------------------------------------
        //---------------------------------------HIỂN THỊ THEO MÃ PHÒNG----------------------------------------
        public static void HienThiPhongTheoMa(string query,int MaPhong, TextBox MaNhaTro, TextBox TenNT, TextBox ST, TextBox TT, TextBox TC, TextBox TP, TextBox TD, TextBox TN )
        {
            string sql = query;
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dataread = cmd.ExecuteReader();
            if (dataread.HasRows)
            {
                dataread.Read();
                MaNhaTro.Text = dataread[0].ToString();
                TenNT.Text = dataread[1].ToString();
                ST.Text = dataread[2].ToString();
                TT.Text = dataread[3].ToString();
                TC.Text = dataread[4].ToString();
                TP.Text = dataread[5].ToString();
                TD.Text = dataread[6].ToString();
                TN.Text = dataread[7].ToString();
            }
        }


        //---------------------------------------------------------END-------------------------------------
        //-----------------------HIỂN THỊ TỔNG SỐ LƯỢNG PHÒNG THEO ĐIỀU KIỆN--------------------------------
        public static int TongPhongTRONG()
        {
            int x;
            string qr = "select count(pt.MaNhaTro)" +
                        " from Phong_Tro as pt where pt.TrangThai = N'Trống' ";

            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qr, conn);
            x = (int)cmd.ExecuteScalar();
            return x;
        }

        public static int TongPhongDaChoThue()
        {
            int x;
            string qr = "select count(pt.MaNhaTro)" +
                        " from Phong_Tro as pt where pt.TrangThai = N'Đã cho thuê' ";

            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qr, conn);
            x = (int)cmd.ExecuteScalar();
            return x;
        }
        //------------Lấy số lượng trạng thái phiếu thu tiền

        public static int TongPhongDaTraTien()
        {
            int x;
            string qr = "SELECT count(hd.MaPhongTro) " +
                        "FROM PhieuDongTienPhong  pdtp, Hop_Dong hd  " +
                        "WHERE pdtp.MaHopDong = hd.MaHopDong AND pdtp.TrangThai = N'Đã đóng'";

            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qr, conn);
            x = (int)cmd.ExecuteScalar();
            return x;
        }
        // ---------------Lấy mã phòng qua mã người thuê

        public static int LayMaPhong(int MaNT)
        {
            int x;
            string qr = "select  hd.MaPhongTro " +
                        "from Nguoi_Thue nt, Hop_Dong hd  " +
                        "where nt.MaNguoiThue = hd.MaNguoiThue and nt.MaNguoiThue = '"+MaNT+"'";

            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qr, conn);
            x = (int)cmd.ExecuteScalar();
            return x;
        }
        public static int TongPhongChuaTraTien()
        {
            int x;
            string qr = "SELECT count(hd.MaPhongTro) " +
                        "FROM PhieuDongTienPhong  pdtp, Hop_Dong hd  " +
                        "WHERE pdtp.MaHopDong = hd.MaHopDong AND pdtp.TrangThai = N'Chưa Đóng'";

            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qr, conn);
            x = (int)cmd.ExecuteScalar();
            return x;
        }
        //-------------------------------------------END--------------------------------------------------------
        //-----------------------------------PHÙNG NHẬT QUANG FORM HOME---------------------------------------------
        //--------------------------------HIỂN THỊ DỮ LIỆU LÊN DATAGRIDVIEW------------------------------------
        public static void HienThiDGV(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            try
            {
                dgv.DataSource = dt;
            }
            catch (SqlException sx)
            {
                MessageBox.Show("Không tìm thấy thông tin: " + sx);
            }
            conn.Close();
            dgv.DataSource = dt;
        }

        public static void HienThiListV(ListView lsV)
        {
            string sql = " SELECT MaNguoiThue, TenNguoiThue, SDT, CMND, case GioiTinh When 1 then N'Nam' when 2 then N'Nữ' else N'Không biết'END as N'Giới tính', convert(varchar(10),NgaySinh,103) as Ngaysinh, DiaChi " +
                          "FROM Nguoi_Thue ";
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            try
            {
                lsV.Items.Clear();
                lsV.View = View.Details;

                lsV.Columns.Add("Mã ngưới thuê").Width = 50;
                lsV.Columns.Add("Tên ngưới thuê").Width = 150;
                lsV.Columns.Add("Số điện thoại").Width = 150;
                lsV.Columns.Add("CMND").Width = 150;
                lsV.Columns.Add("Giới Tính").Width = 70; 
                lsV.Columns.Add("Ngày Sinh").Width = 150;
                lsV.Columns.Add("Địa chỉ").Width = 250;
                lsV.GridLines = true;
                lsV.FullRowSelect = true;
                int stt = 0;
                foreach(DataRow row in dt.Rows)
                {
                    lsV.Items.Add(row[0].ToString());
                    lsV.Items[stt].SubItems.Add(row[1].ToString());
                    lsV.Items[stt].SubItems.Add(row[2].ToString());
                    lsV.Items[stt].SubItems.Add(row[3].ToString());
                    lsV.Items[stt].SubItems.Add(row[4].ToString());
                    lsV.Items[stt].SubItems.Add(row[5].ToString());
                    lsV.Items[stt].SubItems.Add(row[6].ToString());
                    stt++;
                }

            }
            catch (SqlException sx)
            {
                MessageBox.Show("Không tìm thấy thông tin: " + sx);
            }
            conn.Close();
           
        }
        //-------------------------------------------------END------------------------------------------
        //--------------------------------------HIỂN THỊ RA BIỂU ĐỒ
        public static void HienThiChart(string query, Chart chart)
        {
            string sql = query;
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            chart.DataSource = dt;

        }
        //-------------------------------------------------END------------------------------------------
        //Form Số nước ------------------
        public static void HienThiCBB(string query, string id, string ten, ComboBox cbb)
        {
            string sql = query;
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter DTA = new SqlDataAdapter(cmd);
            DTA.Fill(dt);
            if (DTA != null)
            {
                cbb.ValueMember = id;
                cbb.DisplayMember = ten;
                cbb.DataSource = dt;
            }
        }
        //--------------- lay gioi tinh
     


        //-------------------------------------THÊM/SỬU/XÓA DỮ LIỆU---------------------------------------------------------------
        public static void CapNhatGiaDien(int TienDien, int id)
        {

            string sql = "UPDATE Phong_Tro SET TienDien=@TienDien Where MaPhongTro = @id";
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@TienDien", SqlDbType.Int).Value = TienDien;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap Nhat thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cap Nhat That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();

        }
        //-- Cập Nhật Giá Nước
        public static void CapNhatGiaNuoc(int TienNuoc, int id)
        {

            string sql = "UPDATE Phong_Tro SET TienNuoc=@TienNuoc Where MaPhongTro = @id";
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@TienNuoc", SqlDbType.Int).Value = TienNuoc;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap Nhat thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cap Nhat That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();

        }
        //---------------------------------//THÊM/SỬA//Xóa--------------TABLE: NGƯỜI THUÊ
        public static void ThemMoiNguoiThue(Nguoi_Thue nguoi_Thue)
        {
            string query = "INSERT INTO nguoi_thue values (@TenNguoiThue, @SDT,@CMND,@GioiTinh,@NgaySinh,@DiacChi)";
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TenNguoiThue", SqlDbType.NVarChar).Value = nguoi_Thue.TenNguoiThue;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nguoi_Thue.SDT;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = nguoi_Thue.CMND;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Int).Value = nguoi_Thue.GioiTinh;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nguoi_Thue.NgaySinh;
            cmd.Parameters.Add("@DiacChi", SqlDbType.NVarChar).Value = nguoi_Thue.DiaChi;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới người thuê thành công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

        public static void XoaNguoiThue(int MaNguoiThue)
        {
            string query = "DELETE Nguoi_Thue WHERE MaNguoiThue = @MaNguoiThue";
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = MaNguoiThue;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa người thuê thành công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

        public static void CapNhatNguoiThue(Nguoi_Thue nguoi_Thue, int MaNguoiThue)
        {
            string query = "UPDATE Nguoi_Thue set TenNguoiThue = @TenNguoiThue, SDT = @SDT, CMND = @CMND, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi WHERE MaNguoiThue = @MaNguoiThue";
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MaNguoiThue", SqlDbType.Int).Value = MaNguoiThue;
            cmd.Parameters.Add("@TenNguoiThue", SqlDbType.NVarChar).Value = nguoi_Thue.TenNguoiThue;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nguoi_Thue.SDT;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = nguoi_Thue.CMND;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Int).Value = nguoi_Thue.GioiTinh;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nguoi_Thue.NgaySinh;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nguoi_Thue.DiaChi;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap nhat người thuê thành công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cap nhat thất bại: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

    //------------------------------------------------END------------------------------------------------------------------------------

     // Lấy số phòng theo mã nhà trọ
         public static int TongPhongTheoNhatro(int i)
         {
            int x;
            string qurey = "Select dbo.TongPhong('" + i + "')";
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(qurey, conn);
            x = (int)cmd.ExecuteScalar();
            return x;
         }

        //---------------------------------------------------------HIỆN THỊ LIST VIEW DANH SÁCH PHÒNG-----------------------------
        public static void HienThiListPhong(ListView lsV)
        {
            string sql = " SELECT * FROM ALL_TTPT ";
            SqlConnection conn = connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            try
            {
                lsV.Items.Clear();
                lsV.View = View.Details;

                lsV.Columns.Add("Mã Phòng trọ").Width = 100;
                lsV.Columns.Add("Mã nhà trọ").Width = 100;
                lsV.Columns.Add("Số tầng").Width = 100;
                lsV.Columns.Add("Giá thuê").Width = 150;
                lsV.Columns.Add("Tiền đặt cọc").Width = 150;
                lsV.Columns.Add("Tiền điện").Width = 150;
                lsV.Columns.Add("Tiền Nước").Width = 150;
                lsV.Columns.Add("Trạng thái").Width = 250;
                lsV.Columns.Add("Mã người thuê").Width = 100;
                lsV.GridLines = true;
                lsV.FullRowSelect = true;
                int stt = 0;
                foreach (DataRow row in dt.Rows)
                {
                    lsV.Items.Add(row[0].ToString());
                    lsV.Items[stt].SubItems.Add(row[1].ToString());
                    lsV.Items[stt].SubItems.Add(row[2].ToString());
                    lsV.Items[stt].SubItems.Add(row[3].ToString());
                    lsV.Items[stt].SubItems.Add(row[4].ToString());
                    lsV.Items[stt].SubItems.Add(row[5].ToString());
                    lsV.Items[stt].SubItems.Add(row[6].ToString());
                    lsV.Items[stt].SubItems.Add(row[7].ToString());
                    lsV.Items[stt].SubItems.Add(row[8].ToString());
                    stt++;
                }

            }
            catch (SqlException sx)
            {
                MessageBox.Show("Không tìm thấy thông tin: " + sx);
            }
            conn.Close();

        }


    }

}
