using LogisticService.LogisticService;
using LogisticService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Calculations
{
    interface ICalculationService
    {
     //  double CalculatePrice(CarType car, Container container, CrushedCar crashedcar, Route route);
       double CalculatePrice(CalculationModel calculatationModel);
    }
}
