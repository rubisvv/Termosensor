using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Termosensor.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Temperature> Temperatures { get; set; }    
        public PageViewModel PageViewModel { get; set; }
        public DateTime? beginDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}