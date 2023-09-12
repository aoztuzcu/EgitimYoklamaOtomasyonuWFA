using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class OgrenciYoklama: FullAudit<int>
    {
        public Ogrenci Ogrenci { get; set; }
        public int OgrenciId { get; set; }
        public DateTime Tarih { get; set; }
        public int GunlukKatılımYuzdesi { get; set; }

        public ICollection<Yoklama> Yoklamalar { get; set; }

    }
}
