using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class SinifDersGun : FullAudit<int>
    {
        public int SinifId { get; set; }
        public string Gun { get; set; }
        public int GunlukSaat { get; set; }

        public Sinif Sinif { get; set; }
    }
}
