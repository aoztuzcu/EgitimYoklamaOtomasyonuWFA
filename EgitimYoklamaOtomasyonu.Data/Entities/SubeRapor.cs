using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class SubeRapor : BaseRapor
    {
        [ForeignKey("Sube")]
        public int SubeId { get; set; }
        public int KordinatorSayisi { get; set; }
        public int EgitmenSayisi { get; set; }
        public int EgitimSayisi { get; set; }
        public double DersEgitmenOrtalaması { get; set; }

    }
}
