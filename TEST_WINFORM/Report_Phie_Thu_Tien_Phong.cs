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
    public partial class Report_Phie_Thu_Tien_Phong : Form
    {
        int MAPHIEU;
        public Report_Phie_Thu_Tien_Phong(int MaPhieu)
        {
            InitializeComponent();
            MAPHIEU = MaPhieu;
        }

        private void Report_Phie_Thu_Tien_Phong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_Phieu_Dong_Tien_Phong.tb_ChiTietPhieuThuTien' table. You can move, or remove it, as needed.
            this.tb_ChiTietPhieuThuTienTableAdapter.Fill(this.dataset_Phieu_Dong_Tien_Phong.tb_ChiTietPhieuThuTien,MAPHIEU);


            this.rpv_PhieuThuTien.RefreshReport();

            rpv_PhieuThuTien.Reset();

            rpv_PhieuThuTien.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            rpv_PhieuThuTien.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rpv_PhieuThuTien.ZoomPercent = 100;

            dataset_Phieu_Dong_Tien_Phong dataset = new dataset_Phieu_Dong_Tien_Phong();
            dataset.BeginInit();
            this.rpv_PhieuThuTien.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource
                ("rp_PhieuThu", dataset.Tables["tb_ChiTietPhieuThuTien"]));
            this.rpv_PhieuThuTien.LocalReport.ReportPath = "../../Report_PhieuDongTienPhong.rdlc";
            this.rpv_PhieuThuTien.Location = new System.Drawing.Point(0, 0);
            dataset.EndInit();

            string conn = @"Data Source=LAPTOP-C9IT8VA3\SQLEXPRESS;Initial Catalog=QL_NhaTro;Integrated Security=True";
           
            dataset_Phieu_Dong_Tien_PhongTableAdapters.tb_ChiTietPhieuThuTienTableAdapter ta = new dataset_Phieu_Dong_Tien_PhongTableAdapters.tb_ChiTietPhieuThuTienTableAdapter();
            ta.Connection.ConnectionString = conn;
            ta.ClearBeforeFill = true;
            ta.Fill(dataset.tb_ChiTietPhieuThuTien, MAPHIEU);

            this.rpv_PhieuThuTien.RefreshReport();

        }
    }
}
