using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.BLL.Service;
using EgitimYoklamaOtomasyonu.Data.Entities;
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
    public partial class EgitmenForm : Form
    {
        public Kullanici Kullanici { get; set; }
        public EgitmenForm()
        {
            InitializeComponent();
        }

        private void yoklamaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            YoklamaEkleForm yoklamaEkle = new YoklamaEkleForm();
            yoklamaEkle.MdiParent = this;
            panel.Controls.Add(yoklamaEkle);
            yoklamaEkle.Show();
        }

        private void sinifRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            SinifRaporForm sinifRapor = new SinifRaporForm();
            sinifRapor.MdiParent = this;
            panel.Controls.Add(sinifRapor);
            sinifRapor.Show();
        }

        private void EgitmenForm_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            YoklamaEkleForm yoklamaEkle = new YoklamaEkleForm();
            yoklamaEkle.MdiParent = this;
            panel.Controls.Add(yoklamaEkle);
            yoklamaEkle.Show();
        }
    }
}
