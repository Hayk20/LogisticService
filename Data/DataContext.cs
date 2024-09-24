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
		public DbSet<PricePerKilometer> PricePerKilometer { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=LogisticServiceDb;Integrated Security=True;Encrypt=False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Route>()
						.HasOne(o => o.PricePerKilometer)
						.WithMany(c => c.Routes)
						.HasForeignKey(o => o.PricePerKilometerId);
		}
	}
}

