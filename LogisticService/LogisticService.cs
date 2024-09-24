using LogisticService.Calculations;
using LogisticService.Data;
using LogisticService.Models;
using LogisticService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.LogisticService
{
	internal class LogisticService : ILogisticService
	{
		private readonly IRepository<Route, string, DataContext>? _routeRepository;
		private readonly IRepository<CarType, string, DataContext>? _carTypeRepository;
		private readonly IRepository<Container, bool, DataContext>? _containerRepository;
		private readonly IRepository<CrushedCar, bool, DataContext>? _crushedCarRepository;
		private readonly ICalculationService _calculationService;

		public LogisticService(
			IRepository<Route, string, DataContext>? routeRepository,
			IRepository<CarType, string, DataContext>? carTypeRepository,
			IRepository<Container, bool, DataContext>? containerRepository,
			IRepository<CrushedCar, bool, DataContext>? crushedCarRepository
,
			ICalculationService calculationService)
		{
			_routeRepository = routeRepository;
			_carTypeRepository = carTypeRepository;
			_containerRepository = containerRepository;
			_crushedCarRepository = crushedCarRepository;
			_calculationService = calculationService;
		}

		public double GetFixedPrice(LogisticModel model)
		{
			var carType = _carTypeRepository?.Get(model.CarType, "BodyType");
			var container = _containerRepository?.Get(model.IsOpen, "IsOpen");
			var crashedCar = _crushedCarRepository?.Get(model.IsCrushed, "IsCrushed");
			var route = _routeRepository?.Get(key1: model.From, key2: model.To);
			return _calculationService.CalculatePrice(new CalculationModel(carType!, container!, crashedCar!, route!));
		}
	}
}
