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
    public partial class GiaoDienMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public GiaoDienMain()
        {
            InitializeComponent();
            random = new Random();
          
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisebleButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel_TitleBar.BackColor = color;
                    panel_Main.BackColor = ThemeColor.changeColor(color,0.5);
                    panel_Logo.BackColor = ThemeColor.changeColor(color,-0.3);
                }
            }

        }
       private void DisebleButton()
        {
            foreach(Control previousBtn in panel_Menu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm, object sender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Main.Controls.Add(childForm);
            this.panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new HOME(), sender);
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            openChildForm(new Phong(),sender);
            ActivateButton(sender);
        }

        private void btn_HoTro_Click(object sender, EventArgs e)
        {
            openChildForm(new HoTro(),sender);
            ActivateButton(sender);
        }

        private void btn_ChiSoDien_Click(object sender, EventArgs e)
        {
            openChildForm(new ChiSoDien(), sender);
            ActivateButton(sender);
        }

        private void btn_ChiSoNuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new ChiSoNuoc(), sender);
            ActivateButton(sender);
        }

        private void btn_ThanhTien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new TinhTienPhong(), sender);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            QUERY_DB_QLNT.connection();
            
        }

        private void btn_TongPhong_Click(object sender, EventArgs e)
        {
           
        }
    }
}
