using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.BLL.Service;
using EgitimYoklamaOtomasyonu.DAL.Repository;
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

namespace EgitimYoklamaOtomasyonu.UI.EklemeIslem
{
    public partial class KullaniciEkleForm : Form
    {
        private readonly ISubeServis subeServis;
        private readonly IKullaniciServis kullaniciServis;
        public KullaniciEkleForm()
        {
            InitializeComponent();
            subeServis = new SubeServis();
            kullaniciServis = new KullaniciServis();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            KullaniciTipi[] kullanicilar = (KullaniciTipi[])Enum.GetValues(typeof(KullaniciTipi));

            foreach (var tip in kullanicilar)
            {
                cBGorev.Items.Add(tip);
            }
            var list = subeServis.SubeleriGetir();
            foreach (var item in list)
            {
                cBSube.Items.Add(item.Adi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (chkBOtoParola.Checked)
            {
                Guid parola = new Guid();
                txtParola.Text = parola.ToString();
            }
            Kullanici kullanici = new Kullanici()
            {
                Adi = txtAdi.Text,
                SoyAdi = txtSoyad.Text,
                DogumTarihi = dTpDogumTarih.Value,
                KullaniciTipi = (KullaniciTipi)cBGorev.SelectedItem,
                Telefon = mTxtBoxTelefon.Text,
                Mail = txtMail.Text,
                Parola = txtParola.Text
            };
            kullaniciServis.KullaniciEkle(kullanici);
        }

    }
}
