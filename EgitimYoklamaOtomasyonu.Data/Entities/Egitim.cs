using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class Egitim : FullAudit<int>
    {
        public string Adi { get; set; }
        public int ToplamSure { get; set; }
        public string Aciklama { get; set; }

        public ICollection<Sinif> Siniflar { get; set; }
    }
}
