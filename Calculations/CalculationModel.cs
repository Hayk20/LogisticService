using LogisticService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Calculations
{
	public class CalculationModel
	{
		public CalculationModel(CarType carType, Container container, CrushedCar crashedCar, Route route)
		{
			this.CarType = carType;
			this.Container = container;
			this.CrashedCar = crashedCar;
			this.Route = route;
		}

		public CarType CarType { get; set; }
		public Container Container { get; set; }
		public CrushedCar CrashedCar { get; set; }
		public Route Route { get; set; }
	}
}
