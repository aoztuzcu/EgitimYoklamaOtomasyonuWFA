using EgitimYoklamaOtomasyonu.DAL.Context;
using EgitimYoklamaOtomasyonu.Data.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.DAL.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        protected readonly YoklamaContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository()
        {
            _context = new YoklamaContext();
            _dbSet = _context.Set<TEntity>();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            //_ = Discard variable
            _ = _dbSet.Add(entity);
            _ = _context.SaveChanges();
            return entity;
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _ = _context.SaveChanges();
        }

        public virtual void Delete(TKey id)
        {
            TEntity? entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            PropertyInfo silindiMi = typeof(TEntity).GetProperty("SilindiMi");
            if (silindiMi != null && silindiMi.PropertyType == typeof(bool))
            {
                silindiMi.SetValue(entity, true);

                // Varlığın durumunu güncellemek için EntityState.Modified olarak işaretleyebilirsiniz
                _context.Entry(entity).State = EntityState.Modified;
                _ = _context.SaveChanges();
            }
        }

        public virtual List<TEntity> GetAll()
        {
            List<TEntity> list = _dbSet.ToList();
            return list;
        }

        public virtual TEntity GetById(TKey id)
        {
            TEntity result = _dbSet.Find(id);
            return result;
        }

        public virtual List<TEntity> Where(Func<TEntity, bool> filter)
        {
            List<TEntity> list = _dbSet.Where(filter).ToList();
            return list;
        }
        public virtual TEntity FirstEntity(Func<TEntity, bool> filter)
        {
            var entity = _dbSet.FirstOrDefault(filter);
            return entity;
        }
        public virtual IQueryable<TEntity> GetQueryable()
        {
            return _dbSet.AsQueryable();
        }
    }
}
