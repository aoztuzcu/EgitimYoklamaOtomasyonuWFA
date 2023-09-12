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
    public class EgitimServis : IEgitimServis
    {
        //protected readonly YoklamaContext _context;
        //private readonly DbSet<Egitim> _dbSet;
        private readonly IRepository<Egitim , int> repository;
        public EgitimServis()
        {
            //_context = new YoklamaContext();
            //_dbSet = _context.Set<Egitim>();
            repository = new Repository<Egitim , int>();
        }

        public int EgitimSayisiGetir()
        {
            int egitimSayisi = repository.GetAll().Count;
            return egitimSayisi;
        }

        public int EgitimSayisiGetir(int subeId)
        {
            var subeEgitimSayisi = repository.GetQueryable().Include(x => x.Siniflar).ThenInclude(x => x.Sube)
                .Where(x => x.Siniflar.Any(s => s.Sube.Id == subeId)).Count();

            return subeEgitimSayisi;
        }
    }
}
