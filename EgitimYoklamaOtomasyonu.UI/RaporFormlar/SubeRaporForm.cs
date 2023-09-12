using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.BLL.Service;
using EgitimYoklamaOtomasyonu.Data.Entities;
using EgitimYoklamaOtomasyonu.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EgitimYoklamaOtomasyonu.UI
{
    public partial class SubeRaporForm : Form
    {
        private readonly IKullaniciServis kullaniciServis;
        private readonly ISubeServis subeServis;
        private readonly IOgrenciServis ogrenciServis;
        private readonly IEgitimServis egitimServis;
        public Kullanici Kullanici { get; set; }
        public SubeRaporForm()
        {
            InitializeComponent();
            kullaniciServis = new KullaniciServis();
            subeServis = new SubeServis();
            ogrenciServis = new OgrenciServis();
            egitimServis = new EgitimServis();
        }
        public void SubeRaporForm_Load(object sender, EventArgs e)
        {
            var list = subeServis.SubeleriGetir();
            foreach (var item in list)
            {
                cBSube.Items.Add(item.Adi);
            }
            if (Kullanici.KullaniciTipi == KullaniciTipi.Koordinator)
            {
                cBSube.Enabled = false;
                var sube = kullaniciServis.KullaniciSubeGetir(Kullanici.SubeID);
                cBSube.Text = sube.Adi;
                lblKoordinatorSayisi.Text = kullaniciServis.KullaniciSayisiGetir(KullaniciTipi.Koordinator, sube.Id).ToString();
                lblEgitmenSayi.Text = kullaniciServis.KullaniciSayisiGetir(KullaniciTipi.Egitmen, sube.Id).ToString();
                lblOgrenciSayi.Text = ogrenciServis.OgrenciSayisiGetir(sube.Id).ToString();
                lblEgitimSayi.Text = egitimServis.EgitimSayisiGetir(sube.Id).ToString();                
            }
        }

        private void cBSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subeAdi = cBSube.SelectedItem.ToString();
            var sube = subeServis.IlkSube(x => x.Adi == subeAdi);
            lblKoordinatorSayisi.Text = kullaniciServis.KullaniciSayisiGetir(KullaniciTipi.Koordinator, sube.Id).ToString();
            lblEgitmenSayi.Text = kullaniciServis.KullaniciSayisiGetir(KullaniciTipi.Egitmen, sube.Id).ToString();
            lblOgrenciSayi.Text = ogrenciServis.OgrenciSayisiGetir(sube.Id).ToString();
            lblEgitimSayi.Text = egitimServis.EgitimSayisiGetir(sube.Id).ToString();
        }
    }
}
