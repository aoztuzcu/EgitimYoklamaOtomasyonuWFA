namespace EgitimYoklamaOtomasyonu.UI
{
    partial class YoneticiForm
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
            menuStrip1 = new MenuStrip();
            kullaniciIslemleriToolStripMenuItem = new ToolStripMenuItem();
            kullaniciEkleToolStripMenuItem = new ToolStripMenuItem();
            kullaniciGuncelleToolStripMenuItem = new ToolStripMenuItem();
            subeIslemleriToolStripMenuItem = new ToolStripMenuItem();
            subeEkleGuncelleToolStripMenuItem = new ToolStripMenuItem();
            sinifIslemleriToolStripMenuItem = new ToolStripMenuItem();
            egitimEkleGuncelleToolStripMenuItem = new ToolStripMenuItem();
            sinifEkleGuncelleToolStripMenuItem = new ToolStripMenuItem();
            raporIslemleriToolStripMenuItem = new ToolStripMenuItem();
            genelRaporToolStripMenuItem = new ToolStripMenuItem();
            subeRaporToolStripMenuItem = new ToolStripMenuItem();
            sinifRaporToolStripMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { kullaniciIslemleriToolStripMenuItem, subeIslemleriToolStripMenuItem, sinifIslemleriToolStripMenuItem, raporIslemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(717, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kullaniciIslemleriToolStripMenuItem
            // 
            kullaniciIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullaniciEkleToolStripMenuItem, kullaniciGuncelleToolStripMenuItem });
            kullaniciIslemleriToolStripMenuItem.Name = "kullaniciIslemleriToolStripMenuItem";
            kullaniciIslemleriToolStripMenuItem.Size = new Size(111, 20);
            kullaniciIslemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullaniciEkleToolStripMenuItem
            // 
            kullaniciEkleToolStripMenuItem.Name = "kullaniciEkleToolStripMenuItem";
            kullaniciEkleToolStripMenuItem.Size = new Size(168, 22);
            kullaniciEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            kullaniciEkleToolStripMenuItem.Click += kullaniciEkleToolStripMenuItem_Click;
            // 
            // kullaniciGuncelleToolStripMenuItem
            // 
            kullaniciGuncelleToolStripMenuItem.Name = "kullaniciGuncelleToolStripMenuItem";
            kullaniciGuncelleToolStripMenuItem.Size = new Size(168, 22);
            kullaniciGuncelleToolStripMenuItem.Text = "Kullanıcı Güncelle";
            kullaniciGuncelleToolStripMenuItem.Click += kullaniciGuncelleToolStripMenuItem_Click;
            // 
            // subeIslemleriToolStripMenuItem
            // 
            subeIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subeEkleGuncelleToolStripMenuItem });
            subeIslemleriToolStripMenuItem.Name = "subeIslemleriToolStripMenuItem";
            subeIslemleriToolStripMenuItem.Size = new Size(92, 20);
            subeIslemleriToolStripMenuItem.Text = "Şube İşlemleri";
            // 
            // subeEkleGuncelleToolStripMenuItem
            // 
            subeEkleGuncelleToolStripMenuItem.Name = "subeEkleGuncelleToolStripMenuItem";
            subeEkleGuncelleToolStripMenuItem.Size = new Size(173, 22);
            subeEkleGuncelleToolStripMenuItem.Text = "Şube Ekle Güncelle";
            subeEkleGuncelleToolStripMenuItem.Click += subeEkleGuncelleToolStripMenuItem_Click;
            // 
            // sinifIslemleriToolStripMenuItem
            // 
            sinifIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { egitimEkleGuncelleToolStripMenuItem, sinifEkleGuncelleToolStripMenuItem });
            sinifIslemleriToolStripMenuItem.Name = "sinifIslemleriToolStripMenuItem";
            sinifIslemleriToolStripMenuItem.Size = new Size(89, 20);
            sinifIslemleriToolStripMenuItem.Text = "Sınıf İşlemleri";
            // 
            // egitimEkleGuncelleToolStripMenuItem
            // 
            egitimEkleGuncelleToolStripMenuItem.Name = "egitimEkleGuncelleToolStripMenuItem";
            egitimEkleGuncelleToolStripMenuItem.Size = new Size(181, 22);
            egitimEkleGuncelleToolStripMenuItem.Text = "Eğitim Ekle Güncelle";
            egitimEkleGuncelleToolStripMenuItem.Click += egitimEkleGuncelleToolStripMenuItem_Click;
            // 
            // sinifEkleGuncelleToolStripMenuItem
            // 
            sinifEkleGuncelleToolStripMenuItem.Name = "sinifEkleGuncelleToolStripMenuItem";
            sinifEkleGuncelleToolStripMenuItem.Size = new Size(181, 22);
            sinifEkleGuncelleToolStripMenuItem.Text = "Sınıf Ekle Güncelle";
            sinifEkleGuncelleToolStripMenuItem.Click += sinifEkleGuncelleToolStripMenuItem_Click;
            // 
            // raporIslemleriToolStripMenuItem
            // 
            raporIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { genelRaporToolStripMenuItem, subeRaporToolStripMenuItem, sinifRaporToolStripMenuItem });
            raporIslemleriToolStripMenuItem.Name = "raporIslemleriToolStripMenuItem";
            raporIslemleriToolStripMenuItem.Size = new Size(97, 20);
            raporIslemleriToolStripMenuItem.Text = "Rapor İşlemleri";
            // 
            // genelRaporToolStripMenuItem
            // 
            genelRaporToolStripMenuItem.Name = "genelRaporToolStripMenuItem";
            genelRaporToolStripMenuItem.Size = new Size(138, 22);
            genelRaporToolStripMenuItem.Text = "Genel Rapor";
            genelRaporToolStripMenuItem.Click += genelRaporToolStripMenuItem_Click;
            // 
            // subeRaporToolStripMenuItem
            // 
            subeRaporToolStripMenuItem.Name = "subeRaporToolStripMenuItem";
            subeRaporToolStripMenuItem.Size = new Size(138, 22);
            subeRaporToolStripMenuItem.Text = "Şube Rapor";
            subeRaporToolStripMenuItem.Click += subeRaporToolStripMenuItem_Click;
            // 
            // sinifRaporToolStripMenuItem
            // 
            sinifRaporToolStripMenuItem.Name = "sinifRaporToolStripMenuItem";
            sinifRaporToolStripMenuItem.Size = new Size(138, 22);
            sinifRaporToolStripMenuItem.Text = "Sınıf Rapor";
            sinifRaporToolStripMenuItem.Click += sinifRaporToolStripMenuItem_Click;
            // 
            // panel
            // 
            panel.AutoSize = true;
            panel.Location = new Point(0, 27);
            panel.Name = "panel";
            panel.Size = new Size(717, 366);
            panel.TabIndex = 2;
            // 
            // YoneticiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 389);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "YoneticiForm";
            Text = "YoneticiForm";
            Load += YoneticiForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kullaniciIslemleriToolStripMenuItem;
        private ToolStripMenuItem kullaniciEkleToolStripMenuItem;
        private ToolStripMenuItem kullaniciGuncelleToolStripMenuItem;
        private ToolStripMenuItem subeIslemleriToolStripMenuItem;
        private ToolStripMenuItem subeEkleGuncelleToolStripMenuItem;
        private ToolStripMenuItem sinifIslemleriToolStripMenuItem;
        private ToolStripMenuItem egitimEkleGuncelleToolStripMenuItem;
        private ToolStripMenuItem sinifEkleGuncelleToolStripMenuItem;
        private ToolStripMenuItem raporIslemleriToolStripMenuItem;
        private ToolStripMenuItem genelRaporToolStripMenuItem;
        private ToolStripMenuItem subeRaporToolStripMenuItem;
        private ToolStripMenuItem sinifRaporToolStripMenuItem;
        private Panel panel;
    }
}