using LogisticService.Calculations;
using LogisticService.Data;
using LogisticService.LogisticService;
using LogisticService.Menus;
using LogisticService.Models;
using LogisticService.Repository;


class Program
{
	static void Main(String[] args)
	{
		AdminPanelUserInterface adminPanelUserInterface = new AdminPanelUserInterface();
		//adminPanelUserInterface.ShowAdminPanelMenu();
		IRepository<Route, string, DataContext>? routeRepository = new Repository<Route, string, DataContext>();
		IRepository<CarType, string, DataContext>? carTypeRepository = new Repository<CarType, string, DataContext>();
		IRepository<Container, bool, DataContext>? containerRepository = new Repository<Container, bool, DataContext>();
		IRepository<CrushedCar, bool, DataContext>? crushedCarRepository = new Repository<CrushedCar, bool, DataContext>();
		ICalculationService calculationService = new Calculation();

		LogisticService.LogisticService.LogisticService  logisticService=
			new LogisticService.LogisticService.LogisticService(
				routeRepository,
				carTypeRepository,
				containerRepository,
				crushedCarRepository,
				calculationService
				);
		

		Console.WriteLine(logisticService.GetPrice(new LogisticModel("sedan", true, true, "erevan", "artik")));

	}
}

