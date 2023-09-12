
using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities
{
    public class KullaniciGiris : BaseEntity<int>
    {
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
