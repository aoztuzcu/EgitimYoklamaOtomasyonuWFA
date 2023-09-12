using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class Ogrenci: FullAudit<int>
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int SinifId { get; set; }

        public Sinif Sinif { get; set; }
    }
}
