using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.DAL.Context;
using EgitimYoklamaOtomasyonu.DAL.Repository;
using EgitimYoklamaOtomasyonu.Data.Entities;
using EgitimYoklamaOtomasyonu.Data.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EgitimYoklamaOtomasyonu.BLL.Service
{
    public class KullaniciServis : IKullaniciServis
    {
        //protected readonly YoklamaContext _context;
        //private readonly DbSet<Kullanici> _dbSet;
        private readonly IRepository<Kullanici, int> repository;
        public KullaniciServis()
        {
            //_context = new YoklamaContext();
            //_dbSet = _context.Set<Kullanici>();
            repository = new Repository<Kullanici, int>();
        }

        public int KullaniciSayisiGetir(KullaniciTipi tip)
        {
            int yoneticiSayisi = repository.Where(x => x.KullaniciTipi == tip).Count();
            return yoneticiSayisi;
        }
        public Sube KullaniciSubeGetir(int subeId)
        {
            var kullanici = repository.GetQueryable().Include(k => k.SubeID).FirstOrDefault(x => x.SubeID == subeId);
            var sube = kullanici.Sube;
            return sube;
        }

        public int KullaniciSayisiGetir(KullaniciTipi kullaniciTipi, int subeId)
        {
            var kullanici = repository.GetQueryable().Include(k => k.Sube).Where(x => x.SubeID == subeId && x.KullaniciTipi == kullaniciTipi).ToList().Count();
            return kullanici;
        }
        public void KullaniciEkle(Kullanici kullanici)
        {
            repository.Insert(kullanici);
        }
        public Kullanici IlkKullanici(Func<Kullanici, bool> filter)
        {
           return repository.FirstEntity(filter);
        }
    }
}
