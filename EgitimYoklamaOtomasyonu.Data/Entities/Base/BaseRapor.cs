using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities.Base
{
    public abstract class BaseRapor
    {
        [Key]
        public int Id { get; set; }
        public DateTime YaratilmaTarihi { get; set; }
        // Rapor alan kişinin Id
        public int KullaniciId { get; set; }
        public int OgrenciSayisi { get; set; }
        public int VerilenDersSaati { get; set; }

        //Navigation Property
        public virtual Kullanici Kullanici { get; set; }
    }
}
