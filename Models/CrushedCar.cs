using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class CrushedCar
    {
        public CrushedCar(bool isCrushed, float crushRate)
        {
            IsCrushed = isCrushed;
            CrushRate = crushRate;
        }

        public int Id { get; set; }
        public bool IsCrushed { get; set; }
        public float CrushRate { get; set; }
    }
}
