using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class CarView
    {
        public List<Car> Cars { get; set; }

        public void AddCar(string model, int year, string type, int numb, bool active = true)
        {
            Cars.Add(new Car(model, year, type, numb, active));
        }

        //public Car CreateCar(string model, int year, string type, int numb, bool active = true)
        //{
        //    return new Car(model, year, type, numb, active);
        //}

        //Поиск Машины

        public void PrintInfo()
        {
            foreach (Car item in Cars)
            {
                Console.WriteLine("{0}\n------------------------------\n", item);
                
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //public string CarsInfo()
        //{
        //    string str = "";
        //    foreach (Car item in Cars)
        //    {
        //        str += string.Format("{0}\n------------------------------\n", item);
        //    }

        //    return str;
        //}
        
    }
}
