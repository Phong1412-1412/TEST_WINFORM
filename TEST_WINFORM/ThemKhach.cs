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
   
    public partial class ThemKhach : Form
    {
        private readonly Phong phong;
        int MaPhong;
        public ThemKhach(Phong p, int MP)
        {
            InitializeComponent();
            phong = p;
            MaPhong = MP;
        }

        private void btn_QuyLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


    }
}
