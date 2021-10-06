
namespace TEST_WINFORM
{
    partial class ChiSoDien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNha = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCSC = new System.Windows.Forms.TextBox();
            this.txtCSM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbNha);
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 82);
            this.panel1.TabIndex = 6;
            // 
            // cbNha
            // 
            this.cbNha.FormattingEnabled = true;
            this.cbNha.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbNha.Location = new System.Drawing.Point(61, 18);
            this.cbNha.Margin = new System.Windows.Forms.Padding(2);
            this.cbNha.Name = "cbNha";
            this.cbNha.Size = new System.Drawing.Size(152, 21);
            this.cbNha.TabIndex = 5;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbTrangThai.Location = new System.Drawing.Point(359, 18);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(102, 21);
            this.cbTrangThai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(239, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chỉ số điện";
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(37, 204);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(356, 122);
            this.dgvPhong.TabIndex = 9;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(423, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "✓ Lưu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(367, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "🔎︎Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCSC
            // 
            this.txtCSC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCSC.Enabled = false;
            this.txtCSC.Location = new System.Drawing.Point(423, 204);
            this.txtCSC.Margin = new System.Windows.Forms.Padding(2);
            this.txtCSC.Name = "txtCSC";
            this.txtCSC.Size = new System.Drawing.Size(76, 20);
            this.txtCSC.TabIndex = 10;
            // 
            // txtCSM
            // 
            this.txtCSM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCSM.Location = new System.Drawing.Point(423, 279);
            this.txtCSM.Margin = new System.Windows.Forms.Padding(2);
            this.txtCSM.Name = "txtCSM";
            this.txtCSM.Size = new System.Drawing.Size(76, 20);
            this.txtCSM.TabIndex = 11;
            this.txtCSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSM_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(420, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "CS Điện cũ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(420, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "CS Điện mới";
            // 
            // ChiSoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCSM);
            this.Controls.Add(this.txtCSC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChiSoDien";
            this.Text = "ChiSoNuoc";
            this.Load += new System.EventHandler(this.ChiSoDien_Load);
            this.Shown += new System.EventHandler(this.ChiSoDien_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNha;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCSC;
        private System.Windows.Forms.TextBox txtCSM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}