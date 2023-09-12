using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class Sinif: FullAudit<int>
    {
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int SubeId { get; set; }
        public int EgitmenId { get; set; }
        public int EgitimId { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
        public Sube Sube { get; set; }
        public Kullanici Egitmen { get; set; }
        public Egitim Egitim { get; set; }
        public ICollection<SinifDersGun> SinifDersGunler { get; set; }

    }
}
