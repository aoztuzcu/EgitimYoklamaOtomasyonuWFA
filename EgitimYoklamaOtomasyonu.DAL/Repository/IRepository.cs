using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.DAL.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>

    {
        public IQueryable<TEntity> GetQueryable();
        public TEntity Insert(TEntity entity);

        public void Update(TEntity entity);

        public void Delete(TKey id);

        public List<TEntity> GetAll();

        public TEntity GetById(TKey id);

        public List<TEntity> Where(Func<TEntity, bool> filter);
        public TEntity FirstEntity(Func<TEntity, bool> filter);
    }
}
