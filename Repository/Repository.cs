using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Repository
{
    internal class Repository<TEntity, TKey, TDataContext>(TDataContext dataContext) : IRepository<TEntity, TKey, TDataContext> where TEntity : class where TDataContext : DbContext
    {
        private readonly TDataContext _context = dataContext;

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TKey key)
        {
            var entity = _context.Find<TEntity>(key?.GetType(), key)!;
            _context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetItemByKey(TKey key)
        {
            return (TEntity)_context.Find(key?.GetType(), key)!;
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
