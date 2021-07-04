using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Termosensor.Models
{
    public class Temperature
    {
        public int ID { get; set; }
        public decimal TempValue { get; set; }
        //public string TempValueStr { get; set; }
        public DateTime Date { get; set; }
    }
}
