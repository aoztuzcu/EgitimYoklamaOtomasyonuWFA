using EgitimYoklamaOtomasyonu.BLL.Interface;
using EgitimYoklamaOtomasyonu.DAL.Context;
using EgitimYoklamaOtomasyonu.DAL.Repository;
using EgitimYoklamaOtomasyonu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.BLL.Service
{
    public class SubeServis :  ISubeServis
    {
        private readonly IRepository<Sube, int> repository;
        public SubeServis()
        {
            repository = new Repository<Sube, int>();
        }
        public int SubeSayisiGetir()
        {
            int subeSayisi = repository.GetAll().Count();
            return subeSayisi;
        }
        public List<Sube> SubeleriGetir() 
        {
           return repository.GetAll();
        }
        public Sube IlkSube(Func<Sube, bool> filter)
        {
            return repository.FirstEntity(filter);
        }
    }
}
