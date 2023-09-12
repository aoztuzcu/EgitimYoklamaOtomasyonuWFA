using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.BLL.Service;
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
    public partial class GenelRaporForm : Form
    {
        private readonly IKullaniciServis kullaniciServis;
        private readonly ISubeServis subeServis;
        private readonly IOgrenciServis ogrenciServis;
        private readonly IEgitimServis egitimServis;
        public GenelRaporForm()
        {
            InitializeComponent();
            kullaniciServis = new KullaniciServis();
            subeServis = new SubeServis();
            ogrenciServis = new OgrenciServis();
            egitimServis = new EgitimServis();
        }

        private void GenelRaporForm_Load(object sender, EventArgs e)
        {
            lblYoneticiSayi.Text = kullaniciServis.KullaniciSayisiGetir(Data.Entities.Enums.KullaniciTipi.Yonetici).ToString();
            lblKoordinatorSayi.Text = kullaniciServis.KullaniciSayisiGetir(Data.Entities.Enums.KullaniciTipi.Koordinator).ToString();
            lblEgitmenSayi.Text = kullaniciServis.KullaniciSayisiGetir(Data.Entities.Enums.KullaniciTipi.Egitmen).ToString();
            lblSubeSayi.Text = subeServis.SubeSayisiGetir().ToString();
            lblOgrenciSayi.Text = ogrenciServis.OgrenciSayisiGetir().ToString();
            lblEgitimSayi.Text = egitimServis.EgitimSayisiGetir().ToString();
           
        }
    }
}
