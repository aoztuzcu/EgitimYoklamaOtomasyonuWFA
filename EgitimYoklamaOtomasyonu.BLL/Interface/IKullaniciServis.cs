using EgitimYoklamaOtomasyonu.DAL.Repository;
using EgitimYoklamaOtomasyonu.Data.Entities;
using EgitimYoklamaOtomasyonu.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.BLL.Interface
{
    public interface IKullaniciServis 
    {
        public int KullaniciSayisiGetir(KullaniciTipi tip);
        public Sube KullaniciSubeGetir(int subeId);
        public int KullaniciSayisiGetir(KullaniciTipi kullaniciTipi,int subeId);
        public void KullaniciEkle(Kullanici kullanici);
        public Kullanici IlkKullanici(Func<Kullanici, bool> filter);
    }
}
