using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.DAL.Context;
using EgitimYoklamaOtomasyonu.DAL.Repository;
using EgitimYoklamaOtomasyonu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.BLL.Service
{
    public class OgrenciServis : IOgrenciServis
    {
        private readonly IRepository<Ogrenci, int> repository;
        public OgrenciServis()
        {
            repository = new Repository<Ogrenci, int>();
        }
        public int OgrenciSayisiGetir()
        {
            int ogrenciSayisi = repository.GetQueryable().Count();
            return ogrenciSayisi;
        }
        public int OgrenciSayisiGetir(int subeId)
        {
            var subeOgrenciSayisi = repository.GetQueryable().Include(x => x.Sinif).Include(a => a.Sinif.Sube).Where(x => x.Sinif.SubeId == subeId).Count();
            return subeOgrenciSayisi;
        }
    }
}
