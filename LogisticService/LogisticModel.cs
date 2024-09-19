using LogisticService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.LogisticService
{
	internal class LogisticModel
	{
		public LogisticModel(string carType, bool isOpen, bool isCrushed, string from, string to)
		{
			CarType = carType;
			IsOpen = isOpen;
			IsCrushed = isCrushed;
			From = from;
			To = to;
		}

		public string CarType { get; set; }
		public bool IsOpen { get; set; }
        public bool IsCrushed { get; set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}