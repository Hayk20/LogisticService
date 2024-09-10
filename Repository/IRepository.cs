using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Repository
{
    public interface IRepository<TEntity, TKey, TDataContext> where TEntity : class where TDataContext : DbContext
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TKey key);
        IQueryable<TEntity> GetAll();
        TEntity GetItemByKey(TKey key);

    }
}
