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
    public partial class Thống_Kê : Form
    {
        public Thống_Kê()
        {
            InitializeComponent();
        }

        private void Thống_Kê_Load(object sender, EventArgs e)
        {
            
        }
        public void HienThi()
        {

        }
        int i = 1;
        int x = 23;
        int y = 20;
        int KCX = 250;
        int KCY = 260;
        private void btn_ThemPanel_Click(object sender, EventArgs e)
        {
            Panel A = new Panel();
            Panel IconPhong = new Panel();
            Button btn_ChinhSuaPhong = new Button();
            IconPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            IconPhong.BackgroundImage = global::TEST_WINFORM.Properties.Resources._18837429041582692250_32;
            IconPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            IconPhong.Location = new System.Drawing.Point(13, 7);
            IconPhong.Name = "panel_IconPhong";
            IconPhong.Size = new System.Drawing.Size(32, 30);
            IconPhong.TabIndex = 2;
            //-----------------------------------------------------------------------------------
            btn_ChinhSuaPhong.AutoSize = true;
            btn_ChinhSuaPhong.BackColor = System.Drawing.Color.Green;
            btn_ChinhSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ChinhSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_ChinhSuaPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_ChinhSuaPhong.Location = new System.Drawing.Point(13, 171);
            btn_ChinhSuaPhong.Name = "btn_ChinhSuaPhong";
            btn_ChinhSuaPhong.Size = new System.Drawing.Size(81, 25);
            btn_ChinhSuaPhong.TabIndex = 16;
            btn_ChinhSuaPhong.Text = "Chỉnh sửa";
            btn_ChinhSuaPhong.UseVisualStyleBackColor = false;
            //-------------------------------------------------------------------------------------
            Button btn_XoaPhong = new Button();
            btn_XoaPhong.AutoSize = true;
            btn_XoaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btn_XoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_XoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_XoaPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_XoaPhong.Location = new System.Drawing.Point(101, 171);
            btn_XoaPhong.Name = "btn_XoaPhong";
            btn_XoaPhong.Size = new System.Drawing.Size(81, 25);
            btn_XoaPhong.TabIndex = 16;
            btn_XoaPhong.Text = "Xóa phòng";
            btn_XoaPhong.UseVisualStyleBackColor = false;
            //-------------------------------------------------------------------------------------
            Button btn_Tra = new Button();
            btn_Tra.AutoSize = true;
            btn_Tra.BackColor = System.Drawing.Color.DarkCyan;
            btn_Tra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Tra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_Tra.Location = new System.Drawing.Point(13, 52);
            btn_Tra.Name = "btn_Tra";
            btn_Tra.Size = new System.Drawing.Size(45, 25);
            btn_Tra.TabIndex = 8;
            btn_Tra.Text = "Trả";
            btn_Tra.UseVisualStyleBackColor = false;
            //-------------------------------------------------------------------------------------
            Button btn_Sua = new Button();
            btn_Sua.AutoSize = true;
            btn_Sua.BackColor = System.Drawing.Color.DimGray;
            btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_Sua.Location = new System.Drawing.Point(137, 52);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new System.Drawing.Size(45, 25);
            btn_Sua.TabIndex = 10;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            //-------------------------------------------------------------------------------------
            Button btn_Xem = new Button();
            btn_Xem.AutoSize = true;
            btn_Xem.BackColor = System.Drawing.Color.LightSkyBlue;
            btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Xem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_Xem.Location = new System.Drawing.Point(75, 52);
            btn_Xem.Name = "btn_Xem";
            btn_Xem.Size = new System.Drawing.Size(45, 25);
            btn_Xem.TabIndex = 9;
            btn_Xem.Text = "Xem";
            btn_Xem.UseVisualStyleBackColor = false;
            //-------------------------------------------------------------------------------------
            Label lbl_MaPhong = new Label();
            lbl_MaPhong.AutoSize = true;
            lbl_MaPhong.Location = new System.Drawing.Point(51, 14);
            lbl_MaPhong.Name = "lbl_MaPhong";
            lbl_MaPhong.Size = new System.Drawing.Size(60, 16);
            lbl_MaPhong.TabIndex = 0;
            lbl_MaPhong.Text = "Phòng: ";
            //-------------------------------------------------------------------------------------
            Label lbl_TenNguoiThue = new Label();
            lbl_TenNguoiThue.AutoSize = true;
            lbl_TenNguoiThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            lbl_TenNguoiThue.Location = new System.Drawing.Point(12, 90);
            lbl_TenNguoiThue.Name = "lbl_TenNguoiThue";
            lbl_TenNguoiThue.Size = new System.Drawing.Size(43, 16);
            lbl_TenNguoiThue.TabIndex = 12;
            lbl_TenNguoiThue.Text = "Tên: ";
            //-------------------------------------------------------------------------------------
            Label lbl_GiaThue = new Label();
            lbl_GiaThue.AutoSize = true;
            lbl_GiaThue.ForeColor = System.Drawing.Color.DarkRed;
            lbl_GiaThue.Location = new System.Drawing.Point(12, 121);
            lbl_GiaThue.Name = "lbl_GiaThue";
            lbl_GiaThue.Size = new System.Drawing.Size(36, 16);
            lbl_GiaThue.TabIndex = 11;
            lbl_GiaThue.Text = "Giá:";
            //-------------------------------------------------------------------------------------
            //QUERY_DB_QLNT.HienThiPhong(lbl_MaPhong,lbl_TenNguoiThue,lbl_GiaThue,"",);
            //-------------------------------------------------------------------------------------
            A.BackColor = System.Drawing.SystemColors.ActiveCaption;
            A.Controls.Add(IconPhong);
            A.Controls.Add(btn_ChinhSuaPhong);
            A.Controls.Add(btn_XoaPhong);
            A.Controls.Add(btn_Tra);
            A.Controls.Add(btn_Sua);
            A.Controls.Add(btn_Xem);
            A.Controls.Add(lbl_MaPhong);
            A.Controls.Add(lbl_TenNguoiThue);
            A.Controls.Add(lbl_GiaThue);
            A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            A.Location = new System.Drawing.Point(x, y);
            A.Name = i.ToString();
            A.Size = new System.Drawing.Size(200, 220);
            A.TabIndex = 13;
            this.panel_Test.Controls.Add(A);
            x += KCX;
            if(i>=3 && i % 3 == 0)
            {
                y += KCY;
                x = 23;
            }
            i++;
        }
    }
}
