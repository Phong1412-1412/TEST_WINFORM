
namespace TEST_WINFORM
{
    partial class Thống_Kê
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
            this.btn_ThemPanel = new System.Windows.Forms.Button();
            this.panel_Test = new System.Windows.Forms.Panel();
            this.panel_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ThemPanel
            // 
            this.btn_ThemPanel.Location = new System.Drawing.Point(769, 65);
            this.btn_ThemPanel.Name = "btn_ThemPanel";
            this.btn_ThemPanel.Size = new System.Drawing.Size(109, 39);
            this.btn_ThemPanel.TabIndex = 0;
            this.btn_ThemPanel.Text = "Thêm panel";
            this.btn_ThemPanel.UseVisualStyleBackColor = true;
            this.btn_ThemPanel.Click += new System.EventHandler(this.btn_ThemPanel_Click);
            // 
            // panel_Test
            // 
            this.panel_Test.AutoScroll = true;
            this.panel_Test.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_Test.Controls.Add(this.btn_ThemPanel);
            this.panel_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Test.Location = new System.Drawing.Point(0, 0);
            this.panel_Test.Name = "panel_Test";
            this.panel_Test.Size = new System.Drawing.Size(949, 606);
            this.panel_Test.TabIndex = 1;
            // 
            // Thống_Kê
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 606);
            this.Controls.Add(this.panel_Test);
            this.Name = "Thống_Kê";
            this.Text = "Thống_Kê";
            this.Load += new System.EventHandler(this.Thống_Kê_Load);
            this.panel_Test.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThemPanel;
        private System.Windows.Forms.Panel panel_Test;
    }
}