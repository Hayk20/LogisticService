using Microsoft.EntityFrameworkCore;

namespace LogisticService.Repository
{
	public class Repository<TEntity, TKey, TDataContext> :
		IRepository<TEntity, TKey, TDataContext> where TEntity : class where TDataContext : DbContext, new()
	{
		private readonly TDataContext _context;

		public Repository()
		{
			_context = new TDataContext();
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

		public TEntity Get(TKey key, string columnName)
		{
			return _context.Set<TEntity>()
				.SingleOrDefault(e => EF.Property<TKey>(e, $"{columnName}")!.Equals(key))!;
		}

		public TEntity Get(TKey key, TKey key2)
		{
			return _context.Set<TEntity>()
				.SingleOrDefault(e => EF.Property<TKey>(e, "StartingPoint")!.Equals(key) &&
				EF.Property<TKey>(e, "Destination")!.Equals(key2))!;
		}	

		public void Update(TEntity entity)
		{
			_context.Set<TEntity>().Update(entity);
		}

	}
}
