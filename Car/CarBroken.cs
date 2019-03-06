using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class CarBroken
    {
        public DateTime CreateDate { get; set; }
        public Car1 Car1 { get; set; }
        public string Description { get; set; }
        public string RecForRepare { get; set; }
        public User user { get; set; }        
    }
}
