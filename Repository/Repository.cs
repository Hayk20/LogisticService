using Microsoft.EntityFrameworkCore;

namespace LogisticService.Repository
{
	public class Repository<TEntity, TKey, TDataContext> :
		IRepository<TEntity, TKey, TDataContext> where TEntity : class where TDataContext : DbContext, new()
	{
		private readonly TDataContext _context;

		public Repository(TDataContext context)
		{
			_context = context;
		}

		public void Add(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
			_context.SaveChanges();
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
