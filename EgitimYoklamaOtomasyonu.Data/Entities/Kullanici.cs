
using EgitimYoklamaOtomasyonu.Data.Entities;
using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using EgitimYoklamaOtomasyonu.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class Kullanici: FullAudit<int>
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string? FotografAdresi { get; set; }
        public string Mail { get; set; }
        public string Parola { get; set; }
        public KullaniciTipi KullaniciTipi { get; set; }

        public int SubeID { get; set; }
        public Sube Sube { get; set; }
    }
}

