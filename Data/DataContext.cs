using LogisticService.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticService.Data
{
	public class DataContext : DbContext
	{
		public DbSet<Route> Routes { get; set; }
		public DbSet<CarType> CarTypes { get; set; }
		public DbSet<CrushedCar> CrushedCars { get; set; }
		public DbSet<Container> Container { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=LogisticServiceDB;Integrated Security=True;Encrypt=False");
		}
	}
}
