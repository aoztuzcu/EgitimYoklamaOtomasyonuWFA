using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class Yoklama: FullAudit<int>
    {
        public int DersSaati { get; set; }
        public bool GirdiMi { get; set; }
        public int OgrenciYoklamaID { get; set; }

        public OgrenciYoklama OgrenciYoklama { get; set; }
    }
}
