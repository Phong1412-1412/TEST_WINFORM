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
            // TODO: This line of code loads data into the 'PRINT_PDTP.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.PRINT_PDTP.DataTable1,MAPHIEU);
            // TODO: This line of code loads data into the 'dataset_Phieu_Dong_Tien_Phong.tb_ChiTietPhieuThuTien' table. You can move, or remove it, as needed.
            this.rpv_PhieuThuTien.RefreshReport();
            rpv_PhieuThuTien.Reset();

            rpv_PhieuThuTien.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            rpv_PhieuThuTien.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rpv_PhieuThuTien.ZoomPercent = 100;

            PRINT_PDTP dataset = new PRINT_PDTP();
            dataset.BeginInit();
            this.rpv_PhieuThuTien.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource
                ("Data_PDTP_KT", dataset.Tables["DataTable1"]));

            this.rpv_PhieuThuTien.LocalReport.ReportPath = "../../Report_PhieuDongTienPhong.rdlc";
            this.rpv_PhieuThuTien.Location = new System.Drawing.Point(0, 0);
            dataset.EndInit();

            string strSql = @"Data Source=LAPTOP-C9IT8VA3\SQLEXPRESS;Initial Catalog=QL_NHATRO_KT;Integrated Security=True";


            PRINT_PDTPTableAdapters.DataTable1TableAdapter ta = new PRINT_PDTPTableAdapters.DataTable1TableAdapter();
            ta.Connection.ConnectionString = strSql;
            ta.ClearBeforeFill = true;
            ta.Fill(dataset.DataTable1, MAPHIEU);

            this.rpv_PhieuThuTien.RefreshReport();

        }
    }
}
