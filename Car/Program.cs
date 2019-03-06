using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car1> Cars = new List<Car1>();
            Cars.Add(new Car1("1", 2012, "type", 1, true));
            Cars.Add(new Car1("2", 2012, "type", 2, false));
            Cars.Add(new Car1("3", 2012, "type", 3, true));
            Cars.Add(new Car1("4", 2012, "type", 4, false));

            foreach (Car1 item in Cars)
            {
                Console.WriteLine(item);
            }
        } 
    }
}
