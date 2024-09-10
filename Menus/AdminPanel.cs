using LogisticService.Data;
using LogisticService.Models;
using LogisticService.Repository;
using Microsoft.EntityFrameworkCore;

namespace LogisticService.Menus
{
	public class AdminPanelUserInterface
	{
		public class AdminPanel<TEntity, TKey, TDataContext> where TEntity : class where TDataContext : DbContext , new()
		{
			public IRepository<TEntity, TKey, TDataContext> _repository;

			public AdminPanel()
			{
				var dc = new TDataContext();
				dc.Database.EnsureCreated();

				_repository = new Repository<TEntity, TKey, TDataContext>(dc);
			}
		}

		public void ShowAdminPanelMenu()
		{
			Console.WriteLine("1. Route | 2. Container | 3. CarType | 4. CrushedCar");
			int choice = int.Parse(Console.ReadLine()); // fix casting exeption 

			switch (choice)
			{
				case 1:
					ShowRouteMenu(new AdminPanel<Route, int, DataContext>());
					break;
				case 2:
					ShowContainerMenu(new AdminPanel<Container, int, DataContext>());
					break;
				case 3:
					ShowCarTypeMenu(new AdminPanel<CarType, int, DataContext>());
					break;
				case 4:
					ShowCrashedCarMenu(new AdminPanel<CrushedCar, int, DataContext>());
					break;
				default:
					break;
			}
		}

		private void ShowCrashedCarMenu(AdminPanel<CrushedCar, int, DataContext> crashedcarAdminPanel)
		{
			Console.WriteLine("1. Add Crashed Car | 2. Update Cruashed Car | 3. Delete Crashed Car | 4. Get");

			int choice = int.Parse(Console.ReadLine()); // fix casting exeption 

			switch (choice)
			{
				case 1:
					Console.WriteLine("Input is crashed(0, 1)");

					int isCrashed = int.Parse(Console.ReadLine());
					bool crashed = Convert.ToBoolean(isCrashed);

					Console.WriteLine("Input rate");
					float crashRate = float.Parse(Console.ReadLine());

					crashedcarAdminPanel._repository.Add(new CrushedCar(crashed, crashRate));

					break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					break;
				default:
					break;
			}
		}

		private void ShowCarTypeMenu(AdminPanel<CarType, int, DataContext> carTypeAdminPanel)
		{
			throw new NotImplementedException();
		}

		private void ShowContainerMenu(AdminPanel<Container, int, DataContext> ContainerAdminPanel)
		{
			throw new NotImplementedException();
		}

		private void ShowRouteMenu(AdminPanel<Route, int, DataContext> routeAdminPanel)
		{
			throw new NotImplementedException();
		}
	}
}
