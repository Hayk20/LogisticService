using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class CarType
    {
        public CarType(string? bodyType, int coefficient)
        {
            BodyType = bodyType;
            Coefficient = coefficient;
        }

        public int Id { get; set; }
        public string? BodyType { get; set; }
        public int Coefficient { get; set; }
    }
}
