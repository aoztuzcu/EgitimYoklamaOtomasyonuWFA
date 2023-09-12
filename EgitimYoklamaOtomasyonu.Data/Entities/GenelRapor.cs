using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class GenelRapor :BaseRapor
    {
        public int YoneticiSayisi { get; set; }
        public int SubeSayisi { get; set; }
        public int KordinatorSayisi { get; set; }
        public int EgitmenSayisi { get; set; }
        public int EgitimSayisi { get; set; }
        public double DersSubeOrtalaması { get; set; }
        public double DersEgitmenOrtalaması { get; set; }

   
    }
}
