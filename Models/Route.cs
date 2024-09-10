﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class Route
    {
        public Route(string startingPoint, string destination, decimal price)
        {
            StartingPoint = startingPoint;
            Destination = destination;
            Price = price;
        }

        public int Id { get; set; }
        public string StartingPoint { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
    }
}
