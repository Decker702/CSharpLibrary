using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_LINQ//Language Integrated Query
{
    class Program
    {

        static void Main(string[] args)
        {


            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar(){Vin = "A1", Make = "Hyundai", Model = "Elantra", Price = 5000, Year = 2009 },
                new UsedCar(){Vin = "B2", Make = "Hyundai", Model = "Accent", Price = 3000, Year = 2004 },
                new UsedCar(){Vin = "C3", Make = "Ford", Model = "Tarus", Price = 7000, Year = 2010 },
                new UsedCar(){Vin = "D4", Make = "Ford", Model = "Escape", Price = 15000, Year = 2014 },
                new UsedCar(){Vin = "E5", Make = "BMW", Model = "55i", Price = 15000, Year = 2015 },
                new UsedCar(){Vin = "Z5", Make = "BMW", Model = "55i", Price = 9000, Year = 2002 },
                new UsedCar(){Vin = "U10", Make = "Toyota", Model = "4Runner", Price = 6500, Year = 2002 },
                new UsedCar(){Vin = "T2", Make = "Toyota", Model = "Camry", Price = 8700, Year = 2011 },
            };
            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} is a nice used care that costs: {2:C}", 
                    bmw.Year, 
                    bmw.Model, 
                    bmw.Price);
            }

            Console.WriteLine("=================");
            Console.WriteLine("");
            Console.WriteLine("LINQ for cars under $10,000");
            /*good to this point, but won't print what is below.  Think about what you are calling from where
            var cheapCar = from car in usedCars
                            where car.Price <= 1000 
                            select car;

            foreach (var cheapCar in usedCars)
            {
                Console.WriteLine("The {0} {1} is a nice inexpensive car that costs {2:C}",
                    cheapCar.Year,
                    cheapCar.Model,
                    cheapCar.Price);
            }

            Console.ReadLine();
            */

            

               Console.WriteLine("");
                       Console.WriteLine("LINQ with Lambda");
                       var toyotas = usedCars.Where(car => car.Make == "Toyota");
                       foreach (var toyota in toyotas)
                       {
                       Console.WriteLine(  toyota.Model);
                       }
               var niceUsedCares = 
              

            Console.ReadLine();

        }
        class UsedCar
        {
            public string Vin { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }
        }
    }
}
