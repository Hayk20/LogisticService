using LogisticService.Data;
using LogisticService.Models;
using LogisticService.Repository;
using Microsoft.EntityFrameworkCore;

namespace LogisticService.Menus
{
	public class AdminPanelUserInterface
	{
		public class AdminPanel<TEntity, TKey, TDataContext> where TEntity : class where TDataContext : DbContext, new()
		{
			public IRepository<TEntity, TKey, TDataContext> _repository;

			public AdminPanel()
			{
				_repository = new Repository<TEntity, TKey, TDataContext>();
			}
		}

		public void ShowAdminPanelMenu()
		{
			Console.WriteLine("1. Route | 2. Container | 3. CarType | 4. CrushedCar");
			int choice = Convert.ToInt32(Console.ReadLine());

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
			Console.WriteLine("1. Add Crashed Car | 2. Update Crashed Car | 3. Delete Crashed Car | 4. Get crashed car");

			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Console.WriteLine("Input is crashed(0, 1)");

					int isCrashed = Convert.ToInt32(Console.ReadLine());
					bool crashed = Convert.ToBoolean(isCrashed);

					Console.WriteLine("Input rate");
					double crashRate = Convert.ToDouble(Console.ReadLine());

					crashedcarAdminPanel._repository.Add(new CrushedCar(crashed, crashRate));

					break;
				case 2:
					Console.WriteLine("Input is crashed(0, 1)");
					int isCrashedNew = Convert.ToInt32(Console.ReadLine());
					bool crashedNew = Convert.ToBoolean(isCrashedNew);

					Console.WriteLine("Input rate");
					double crashRateNew = Convert.ToDouble(Console.ReadLine());

					crashedcarAdminPanel._repository.Update(new CrushedCar(crashedNew, crashRateNew));
					break;
				case 3:
					Console.WriteLine("Input car ID to delete");
					int carIdDelete = Convert.ToInt32(Console.ReadLine());

					crashedcarAdminPanel._repository.Delete(carIdDelete);
					break;
				case 4:
					Console.WriteLine("Input car ID to get");
					int carIdGet = Convert.ToInt32(Console.ReadLine());

					crashedcarAdminPanel._repository.Get(carIdGet, "Id").ShowInfo();
					break;
				default:
					Console.WriteLine("Insert valid option");
					break;
			}
		}

		private void ShowRouteMenu(AdminPanel<Route, int, DataContext> routeAdminPanel)
		{
			Console.WriteLine("1. Add Route | 2. Update Route | 3. Delete Route | 4. Get Route");

			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Console.WriteLine("Input starting point");
					string startingPoint = Console.ReadLine()!;

					Console.WriteLine("Input destination");
					string destination = Console.ReadLine()!;

					Console.WriteLine("Input price");
					double price = Convert.ToDouble(Console.ReadLine());

					routeAdminPanel._repository.Add(new Route(startingPoint, destination, price));
					break;
				case 2:
					Console.WriteLine("Input starting point");
					string startingPointNew = Console.ReadLine()!;

					Console.WriteLine("Input destination");
					string destinationNew = Console.ReadLine()!;

					Console.WriteLine("Input price");
					double priceNew = Convert.ToDouble(Console.ReadLine());

					routeAdminPanel._repository.Update(new Route(startingPointNew, destinationNew, priceNew));
					break;
				case 3:
					Console.WriteLine("Input route ID to delete");
					int routeIdDelete = Convert.ToInt32(Console.ReadLine());

					routeAdminPanel._repository.Delete(routeIdDelete);
					break;
				case 4:
					Console.WriteLine("Input route ID to get");
					int routeIdGet = Convert.ToInt32(Console.ReadLine());

					routeAdminPanel._repository.Get(routeIdGet, "Id").ShowInfo();
					break;
				default:
					Console.WriteLine("Insert valid option");
					break;
			}
		}

		private void ShowContainerMenu(AdminPanel<Container, int, DataContext> ContainerAdminPanel)
		{
			Console.WriteLine("1. Add container | 2. Update container | 3. Delete container | 4. Get container");

			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Console.WriteLine("Input container type");
					bool containerType = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Input coefficient");
					double containerCoefficient = Convert.ToDouble(Console.ReadLine());

					ContainerAdminPanel._repository.Add(new Container(containerType, containerCoefficient));
					break;
				case 2:
					Console.WriteLine("Input container type");
					bool containerTypeNew = Convert.ToBoolean(Console.ReadLine());

					Console.WriteLine("Input coefficient");
					double containerCoefficientNew = Convert.ToDouble(Console.ReadLine());

					ContainerAdminPanel._repository.Update(new Container(containerTypeNew, containerCoefficientNew));
					break;
				case 3:
					Console.WriteLine("Input container ID to delete");
					int containerIdDelete = Convert.ToInt32(Console.ReadLine());

					ContainerAdminPanel._repository.Delete(containerIdDelete);
					break;
				case 4:
					Console.WriteLine("Input container ID to get");
					int containerIdGet = Convert.ToInt32(Console.ReadLine());

					ContainerAdminPanel._repository.Get(containerIdGet, "Id").ShowInfo();
					break;
				default:
					Console.WriteLine("Insert valid option");
					break;
			}
		}

		private void ShowCarTypeMenu(AdminPanel<CarType, int, DataContext> ContainerAdminPanel)
		{
			Console.WriteLine("1. Add car type | 2. Update car type | 3. Delete car type | 4. Get car type");

			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Console.WriteLine("Input body type");

					string bodyType = Console.ReadLine()!;

					Console.WriteLine("Input coefficient");
					double bodyTypeCoeffiecient = Convert.ToDouble(Console.ReadLine());

					ContainerAdminPanel._repository.Add(new CarType(bodyType, bodyTypeCoeffiecient));

					break;
				case 2:
					Console.WriteLine("Input body type");

					string bodyTypeNew = Console.ReadLine()!;

					Console.WriteLine("Input coefficient");
					double bodyTypeCoeffiecientNew = Convert.ToDouble(Console.ReadLine());

					ContainerAdminPanel._repository.Update(new CarType(bodyTypeNew, bodyTypeCoeffiecientNew));
					break;
				case 3:
					Console.WriteLine("Input body type ID to delete");
					int bodyTypeIdDelete = Convert.ToInt32(Console.ReadLine());

					ContainerAdminPanel._repository.Delete(bodyTypeIdDelete);
					break;
				case 4:
					Console.WriteLine("Input body type ID to get");
					int bodyTypeIdGet = Convert.ToInt32(Console.ReadLine());

					ContainerAdminPanel._repository.Get(bodyTypeIdGet, "Id").ShowInfo();
					break;
				default:
					Console.WriteLine("Insert valid option");
					break;
			}
		}

	}
}
