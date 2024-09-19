using Microsoft.EntityFrameworkCore;

namespace LogisticService.Repository
{
	public interface IRepository<TEntity, TKey, TDataContext> where TEntity : class where TDataContext : DbContext, new()
	{
		void Add(TEntity entity);
		void Update(TEntity entity);
		void Delete(TKey key);
		IQueryable<TEntity> GetAll();
		TEntity Get(TKey key, string columnName);
		TEntity Get1(TKey key, TKey key2);
	}
}
