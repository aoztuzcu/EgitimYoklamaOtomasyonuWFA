using EgitimYoklamaOtomasyonu.Data.Entities;
using EgitimYoklamaOtomasyonu.UI.EklemeGuncellemeFormlar;
using EgitimYoklamaOtomasyonu.UI.EklemeIslem;
using EgitimYoklamaOtomasyonu.UI.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimYoklamaOtomasyonu.UI
{
    public partial class KoordinatorForm : Form
    {
        public Kullanici Kullanici { get; set; }
        public KoordinatorForm()
        {
            InitializeComponent();
        }

        private void egitmenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            KullaniciEkleForm kullaniciEkle = new KullaniciEkleForm();
            kullaniciEkle.MdiParent = this;
            panel.Controls.Add(kullaniciEkle);
            kullaniciEkle.Show();
        }

        private void egitmenSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            KullaniciGuncelleForm kullaniciGuncelle = new KullaniciGuncelleForm();
            kullaniciGuncelle.MdiParent = this;
            panel.Controls.Add(kullaniciGuncelle);
            kullaniciGuncelle.Show();
        }

        private void egitimEkleGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            EgitimEkleGuncelleSil egitimEkle = new EgitimEkleGuncelleSil();
            egitimEkle.MdiParent = this;
            panel.Controls.Add(egitimEkle);
            egitimEkle.Show();
        }

        private void sinifEkleGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            SinifEkleGuncelleForm sinifEkleGuncelle = new SinifEkleGuncelleForm();
            sinifEkleGuncelle.MdiParent = this;
            panel.Controls.Add(sinifEkleGuncelle);
            sinifEkleGuncelle.Show();
        }

        private void subeRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            SubeRaporForm subeRapor = new SubeRaporForm();
            subeRapor.Kullanici = Kullanici;
            subeRapor.MdiParent = this;
            panel.Controls.Add(subeRapor);
            subeRapor.Show();
        }

        private void sinifRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            SinifRaporForm sinifRapor = new SinifRaporForm();
            sinifRapor.MdiParent = this;
            panel.Controls.Add(sinifRapor);
            sinifRapor.Show();
        }

        private void KoordinatorForm_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            SubeRaporForm subeRapor = new SubeRaporForm();
            subeRapor.Kullanici = Kullanici;
            subeRapor.MdiParent = this;
            panel.Controls.Add(subeRapor);
            subeRapor.Show();
        }
    }
}
