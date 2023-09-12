using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class SinifRapor:BaseRapor
    {
        public string EğitmenAdSoyAd { get; set; }
        public int SubeId { get; set; }
        public int SinifId { get; set; }
        public int KalanDersSaati { get; set; }

    }
}
