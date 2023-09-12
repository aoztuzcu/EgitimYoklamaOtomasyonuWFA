namespace EgitimYoklamaOtomasyonu.UI
{
    partial class EgitmenForm
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
            yoklamaIslemleriToolStripMenuItem = new ToolStripMenuItem();
            yoklamaEkleToolStripMenuItem = new ToolStripMenuItem();
            raporIslemleriToolStripMenuItem = new ToolStripMenuItem();
            sinifRaporToolStripMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yoklamaIslemleriToolStripMenuItem, raporIslemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(717, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yoklamaIslemleriToolStripMenuItem
            // 
            yoklamaIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yoklamaEkleToolStripMenuItem });
            yoklamaIslemleriToolStripMenuItem.Name = "yoklamaIslemleriToolStripMenuItem";
            yoklamaIslemleriToolStripMenuItem.Size = new Size(111, 20);
            yoklamaIslemleriToolStripMenuItem.Text = "Yoklama İşlemleri";
            // 
            // yoklamaEkleToolStripMenuItem
            // 
            yoklamaEkleToolStripMenuItem.Name = "yoklamaEkleToolStripMenuItem";
            yoklamaEkleToolStripMenuItem.Size = new Size(143, 22);
            yoklamaEkleToolStripMenuItem.Text = "Yoklama Ekle";
            yoklamaEkleToolStripMenuItem.Click += yoklamaEkleToolStripMenuItem_Click;
            // 
            // raporIslemleriToolStripMenuItem
            // 
            raporIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinifRaporToolStripMenuItem });
            raporIslemleriToolStripMenuItem.Name = "raporIslemleriToolStripMenuItem";
            raporIslemleriToolStripMenuItem.Size = new Size(97, 20);
            raporIslemleriToolStripMenuItem.Text = "Rapor İşlemleri";
            // 
            // sinifRaporToolStripMenuItem
            // 
            sinifRaporToolStripMenuItem.Name = "sinifRaporToolStripMenuItem";
            sinifRaporToolStripMenuItem.Size = new Size(131, 22);
            sinifRaporToolStripMenuItem.Text = "Sınıf Rapor";
            sinifRaporToolStripMenuItem.Click += sinifRaporToolStripMenuItem_Click;
            // 
            // panel
            // 
            panel.AutoSize = true;
            panel.Location = new Point(0, 27);
            panel.Name = "panel";
            panel.Size = new Size(717, 361);
            panel.TabIndex = 3;
            // 
            // EgitmenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 389);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "EgitmenForm";
            Text = "EgitmenForm";
            Load += EgitmenForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem yoklamaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem raporİşlemleriToolStripMenuItem;
        private ToolStripMenuItem sınıfRaporToolStripMenuItem;
        private ToolStripMenuItem yoklamaEkleToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem yoklamaIslemleriToolStripMenuItem;
        private ToolStripMenuItem raporIslemleriToolStripMenuItem;
        private ToolStripMenuItem sinifRaporToolStripMenuItem;
        private Panel panel;
    }
}