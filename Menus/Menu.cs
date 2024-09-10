using LogisticService.Data;
using LogisticService.Models;
using LogisticService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Menus
{
    internal class Menu
    {
        IRepository<Route, int, DataContext> RouteRepository = new Repository<Route, int, DataContext>(DataContext);


    }
}
