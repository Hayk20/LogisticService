using LogisticService.LogisticService;
using LogisticService.Models;

namespace LogisticService.Calculations
{
	public class CalculationService : ICalculationService
	{
		public double CalculatePrice(CalculationModel calculatationModel)
		{
			return calculatationModel.Route.Price * calculatationModel.CarType.Coefficient * calculatationModel.CrashedCar.CrushRate * calculatationModel.Container.Coefficient;
		}
	}
}
