using EgitimYoklamaOtomasyonu.DAL.Repository;
using EgitimYoklamaOtomasyonu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.BLL.Interface
{
    public interface IEgitimServis
    {
        public int EgitimSayisiGetir();
        public int EgitimSayisiGetir(int subeId);
    }
}
