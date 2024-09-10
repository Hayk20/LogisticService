using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    internal class Container
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }

        public Container(bool isOpen)
        {
            IsOpen = isOpen;
        }
    }
}
