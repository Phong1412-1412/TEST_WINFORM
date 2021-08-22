
namespace TEST_WINFORM
{
    partial class HOME
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_MainHome = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TongPhong = new System.Windows.Forms.Button();
            this.btn_PhongTrong = new System.Windows.Forms.Button();
            this.btn_PhongThue = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvNoTien = new System.Windows.Forms.DataGridView();
            this.panel_MainHome.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MainHome
            // 
            this.panel_MainHome.AutoScroll = true;
            this.panel_MainHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel_MainHome.Controls.Add(this.panel4);
            this.panel_MainHome.Controls.Add(this.panel2);
            this.panel_MainHome.Controls.Add(this.panel1);
            this.panel_MainHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainHome.Location = new System.Drawing.Point(0, 0);
            this.panel_MainHome.Name = "panel_MainHome";
            this.panel_MainHome.Size = new System.Drawing.Size(939, 526);
            this.panel_MainHome.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.label7.Location = new System.Drawing.Point(66, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh sách khách nợ tiền phòng";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.label6.Location = new System.Drawing.Point(171, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách phòng ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart_DoanhThu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(607, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 275);
            this.panel2.TabIndex = 4;
            // 
            // chart_DoanhThu
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea5);
            this.chart_DoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend5.Name = "Legend1";
            this.chart_DoanhThu.Legends.Add(legend5);
            this.chart_DoanhThu.Location = new System.Drawing.Point(0, 64);
            this.chart_DoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.LegendText = "Doanh thu";
            series5.Name = "chartDoanhThu";
            this.chart_DoanhThu.Series.Add(series5);
            this.chart_DoanhThu.Size = new System.Drawing.Size(332, 211);
            this.chart_DoanhThu.TabIndex = 1;
            this.chart_DoanhThu.Text = "chart1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.label5.Location = new System.Drawing.Point(103, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvPhong);
            this.panel1.Controls.Add(this.btn_PhongThue);
            this.panel1.Controls.Add(this.btn_PhongTrong);
            this.panel1.Controls.Add(this.btn_TongPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 526);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(171, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái phòng";
            // 
            // btn_TongPhong
            // 
            this.btn_TongPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TongPhong.BackColor = System.Drawing.Color.Teal;
            this.btn_TongPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TongPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TongPhong.Location = new System.Drawing.Point(104, 107);
            this.btn_TongPhong.Name = "btn_TongPhong";
            this.btn_TongPhong.Size = new System.Drawing.Size(105, 65);
            this.btn_TongPhong.TabIndex = 1;
            this.btn_TongPhong.Text = "Tổng phòng: ";
            this.btn_TongPhong.UseVisualStyleBackColor = false;
            this.btn_TongPhong.Click += new System.EventHandler(this.btn_TongPhong_Click);
            // 
            // btn_PhongTrong
            // 
            this.btn_PhongTrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_PhongTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhongTrong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PhongTrong.Location = new System.Drawing.Point(234, 107);
            this.btn_PhongTrong.Name = "btn_PhongTrong";
            this.btn_PhongTrong.Size = new System.Drawing.Size(105, 65);
            this.btn_PhongTrong.TabIndex = 2;
            this.btn_PhongTrong.Text = "Phòng trống: ";
            this.btn_PhongTrong.UseVisualStyleBackColor = false;
            this.btn_PhongTrong.Click += new System.EventHandler(this.btn_PhongTrong_Click);
            // 
            // btn_PhongThue
            // 
            this.btn_PhongThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PhongThue.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_PhongThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhongThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PhongThue.Location = new System.Drawing.Point(356, 107);
            this.btn_PhongThue.Name = "btn_PhongThue";
            this.btn_PhongThue.Size = new System.Drawing.Size(105, 65);
            this.btn_PhongThue.TabIndex = 3;
            this.btn_PhongThue.Text = "Phòng thuê: ";
            this.btn_PhongThue.UseVisualStyleBackColor = false;
            this.btn_PhongThue.Click += new System.EventHandler(this.btn_PhongThue_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhong.Location = new System.Drawing.Point(0, 355);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(607, 171);
            this.dgvPhong.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvNoTien);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(607, 275);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 251);
            this.panel4.TabIndex = 6;
            // 
            // dgvNoTien
            // 
            this.dgvNoTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNoTien.Location = new System.Drawing.Point(0, 80);
            this.dgvNoTien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNoTien.Name = "dgvNoTien";
            this.dgvNoTien.RowHeadersWidth = 51;
            this.dgvNoTien.RowTemplate.Height = 24;
            this.dgvNoTien.Size = new System.Drawing.Size(332, 171);
            this.dgvNoTien.TabIndex = 1;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 526);
            this.Controls.Add(this.panel_MainHome);
            this.Name = "HOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.panel_MainHome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MainHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_PhongThue;
        private System.Windows.Forms.Button btn_PhongTrong;
        private System.Windows.Forms.Button btn_TongPhong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvNoTien;
        private System.Windows.Forms.DataGridView dgvPhong;
    }
}