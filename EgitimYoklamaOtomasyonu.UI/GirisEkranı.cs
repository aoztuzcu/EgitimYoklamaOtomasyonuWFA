using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.BLL.Service;
using EgitimYoklamaOtomasyonu.Data.Entities;
using EgitimYoklamaOtomasyonu.Data.Entities.Enums;

namespace EgitimYoklamaOtomasyonu.UI
{
    public partial class GirisEkran� : Form
    {
        private readonly IKullaniciServis servis;
        public GirisEkran�()
        {
            InitializeComponent();
            servis = new KullaniciServis();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // sertvis i�ine first entity i ekle
            var kullanici = servis.IlkKullanici(u => u.Mail == txtMail.Text && u.Parola == txtParola.Text);
            if (kullanici != null)
            {
                MessageBox.Show("Tebrikler Giri� yapt�n�z!");
                KullaniciFormAc(kullanici);
            }
        }

        private void checkBoxParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxParolaGoster.Checked)
            {
                txtParola.UseSystemPasswordChar = false;
            }
            else
            {
                txtParola.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// kullanici tipine g�re hangi formun a��laca��n� belirler.Normalde servis i�erisinde olmas� gerekir ancak form oldu�u i�in
        /// servise tan�mlayam�yoruz.
        /// </summary>
        /// <param name="kullanici"></param>
        public void KullaniciFormAc(Kullanici kullanici)
        {
            switch (kullanici.KullaniciTipi)
            {
                case KullaniciTipi.Yonetici:
                    {
                        YoneticiForm yonetici = new YoneticiForm();
                        yonetici.Kullanici = kullanici;
                        yonetici.Show();
                        this.Hide();
                        break;
                    }
                case KullaniciTipi.Koordinator:
                    {
                        KoordinatorForm koordinator = new KoordinatorForm();
                        koordinator.Kullanici = kullanici;
                        koordinator.Show();
                        this.Hide();
                        break;
                    }
                case KullaniciTipi.Egitmen:
                    {
                        EgitmenForm egitmen = new EgitmenForm();
                        egitmen.Kullanici = kullanici;
                        egitmen.Show();
                        this.Hide();
                        break;
                    }
            }
        }
    }
}