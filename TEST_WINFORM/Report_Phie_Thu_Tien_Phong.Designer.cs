
namespace TEST_WINFORM
{
    partial class Report_Phie_Thu_Tien_Phong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MaPhongCT = new System.Windows.Forms.Label();
            this.rpv_PhieuThuTien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataset_Phieu_Dong_Tien_Phong = new TEST_WINFORM.dataset_Phieu_Dong_Tien_Phong();
            this.tb_ChiTietPhieuThuTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ChiTietPhieuThuTienTableAdapter = new TEST_WINFORM.dataset_Phieu_Dong_Tien_PhongTableAdapters.tb_ChiTietPhieuThuTienTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_Phieu_Dong_Tien_Phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChiTietPhieuThuTienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_MaPhongCT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 120);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // lbl_MaPhongCT
            // 
            this.lbl_MaPhongCT.AutoSize = true;
            this.lbl_MaPhongCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaPhongCT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_MaPhongCT.Location = new System.Drawing.Point(12, 21);
            this.lbl_MaPhongCT.Name = "lbl_MaPhongCT";
            this.lbl_MaPhongCT.Size = new System.Drawing.Size(205, 24);
            this.lbl_MaPhongCT.TabIndex = 10;
            this.lbl_MaPhongCT.Text = "Phiếu thu tiền phòng";
            // 
            // rpv_PhieuThuTien
            // 
            this.rpv_PhieuThuTien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rp_PhieuThu";
            reportDataSource1.Value = this.tb_ChiTietPhieuThuTienBindingSource;
            this.rpv_PhieuThuTien.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_PhieuThuTien.LocalReport.ReportEmbeddedResource = "TEST_WINFORM.Report_PhieuDongTienPhong.rdlc";
            this.rpv_PhieuThuTien.Location = new System.Drawing.Point(0, 120);
            this.rpv_PhieuThuTien.Name = "rpv_PhieuThuTien";
            this.rpv_PhieuThuTien.ServerReport.BearerToken = null;
            this.rpv_PhieuThuTien.Size = new System.Drawing.Size(836, 337);
            this.rpv_PhieuThuTien.TabIndex = 1;
            // 
            // dataset_Phieu_Dong_Tien_Phong
            // 
            this.dataset_Phieu_Dong_Tien_Phong.DataSetName = "dataset_Phieu_Dong_Tien_Phong";
            this.dataset_Phieu_Dong_Tien_Phong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ChiTietPhieuThuTienBindingSource
            // 
            this.tb_ChiTietPhieuThuTienBindingSource.DataMember = "tb_ChiTietPhieuThuTien";
            this.tb_ChiTietPhieuThuTienBindingSource.DataSource = this.dataset_Phieu_Dong_Tien_Phong;
            // 
            // tb_ChiTietPhieuThuTienTableAdapter
            // 
            this.tb_ChiTietPhieuThuTienTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Phie_Thu_Tien_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 457);
            this.Controls.Add(this.rpv_PhieuThuTien);
            this.Controls.Add(this.panel1);
            this.Name = "Report_Phie_Thu_Tien_Phong";
            this.Text = "Report_Phie_Thu_Tien_Phong";
            this.Load += new System.EventHandler(this.Report_Phie_Thu_Tien_Phong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_Phieu_Dong_Tien_Phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChiTietPhieuThuTienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MaPhongCT;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_PhieuThuTien;
        private System.Windows.Forms.BindingSource tb_ChiTietPhieuThuTienBindingSource;
        private dataset_Phieu_Dong_Tien_Phong dataset_Phieu_Dong_Tien_Phong;
        private dataset_Phieu_Dong_Tien_PhongTableAdapters.tb_ChiTietPhieuThuTienTableAdapter tb_ChiTietPhieuThuTienTableAdapter;
    }
}