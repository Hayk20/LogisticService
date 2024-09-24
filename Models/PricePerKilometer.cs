using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
	public class PricePerKilometer
	{
		public PricePerKilometer(int price)
		{
			Price = price;
		}

		public int PricePerKilometerId { get; set; }
		public int Price { get; set; }
		public List<Route> Routes { get; set; }// = new List<Route>();
	}
}
