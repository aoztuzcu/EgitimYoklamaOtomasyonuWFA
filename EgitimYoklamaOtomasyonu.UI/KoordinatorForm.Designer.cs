namespace EgitimYoklamaOtomasyonu.UI
{
    partial class KoordinatorForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            egitmenIslemleriToolStripMenuItem = new ToolStripMenuItem();
            egitmenEkleToolStripMenuItem = new ToolStripMenuItem();
            egitmenSilToolStripMenuItem = new ToolStripMenuItem();
            sinifIslemleriToolStripMenuItem = new ToolStripMenuItem();
            egitimEkleGuncelleToolStripMenuItem = new ToolStripMenuItem();
            sinifEkleGuncelleToolStripMenuItem = new ToolStripMenuItem();
            raporIslemleriToolStripMenuItem = new ToolStripMenuItem();
            subeRaporToolStripMenuItem = new ToolStripMenuItem();
            sinifRaporToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            panel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { egitmenIslemleriToolStripMenuItem, sinifIslemleriToolStripMenuItem, raporIslemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(717, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // egitmenIslemleriToolStripMenuItem
            // 
            egitmenIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { egitmenEkleToolStripMenuItem, egitmenSilToolStripMenuItem });
            egitmenIslemleriToolStripMenuItem.Name = "egitmenIslemleriToolStripMenuItem";
            egitmenIslemleriToolStripMenuItem.Size = new Size(110, 20);
            egitmenIslemleriToolStripMenuItem.Text = "Eğitmen İşlemleri";
            // 
            // egitmenEkleToolStripMenuItem
            // 
            egitmenEkleToolStripMenuItem.Name = "egitmenEkleToolStripMenuItem";
            egitmenEkleToolStripMenuItem.Size = new Size(142, 22);
            egitmenEkleToolStripMenuItem.Text = "Eğitmen Ekle";
            egitmenEkleToolStripMenuItem.Click += egitmenEkleToolStripMenuItem_Click;
            // 
            // egitmenSilToolStripMenuItem
            // 
            egitmenSilToolStripMenuItem.Name = "egitmenSilToolStripMenuItem";
            egitmenSilToolStripMenuItem.Size = new Size(142, 22);
            egitmenSilToolStripMenuItem.Text = "Eğitmen Sil";
            egitmenSilToolStripMenuItem.Click += egitmenSilToolStripMenuItem_Click;
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
            raporIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subeRaporToolStripMenuItem, sinifRaporToolStripMenuItem });
            raporIslemleriToolStripMenuItem.Name = "raporIslemleriToolStripMenuItem";
            raporIslemleriToolStripMenuItem.Size = new Size(97, 20);
            raporIslemleriToolStripMenuItem.Text = "Rapor İşlemleri";
            // 
            // subeRaporToolStripMenuItem
            // 
            subeRaporToolStripMenuItem.Name = "subeRaporToolStripMenuItem";
            subeRaporToolStripMenuItem.Size = new Size(134, 22);
            subeRaporToolStripMenuItem.Text = "Şube Rapor";
            subeRaporToolStripMenuItem.Click += subeRaporToolStripMenuItem_Click;
            // 
            // sinifRaporToolStripMenuItem
            // 
            sinifRaporToolStripMenuItem.Name = "sinifRaporToolStripMenuItem";
            sinifRaporToolStripMenuItem.Size = new Size(134, 22);
            sinifRaporToolStripMenuItem.Text = "Sınıf Rapor";
            sinifRaporToolStripMenuItem.Click += sinifRaporToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // panel
            // 
            panel.AutoSize = true;
            panel.Location = new Point(0, 27);
            panel.Name = "panel";
            panel.Size = new Size(717, 365);
            panel.TabIndex = 3;
            // 
            // KoordinatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 389);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "KoordinatorForm";
            Text = "KoordinatorForm";
            Load += KoordinatorForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem egitmenIslemleriToolStripMenuItem;
        private ToolStripMenuItem egitmenEkleToolStripMenuItem;
        private ToolStripMenuItem egitmenSilToolStripMenuItem;
        private ToolStripMenuItem sinifIslemleriToolStripMenuItem;
        private ToolStripMenuItem raporIslemleriToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem egitimEkleGuncelleToolStripMenuItem;
        private ToolStripMenuItem sinifEkleGuncelleToolStripMenuItem;
        private ToolStripMenuItem subeRaporToolStripMenuItem;
        private ToolStripMenuItem sinifRaporToolStripMenuItem;
        private Panel panel;
    }
}