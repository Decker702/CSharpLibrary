using System;

namespace Test
{
    class Program

    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() { VIN = "A1", Make = "Hyundai", Model = "Elantra", Price = 5000, Year = 2009 },
                new UsedCar() { VIN = "B1", Make = "Hyundai", Model = "Accent", Price = 3000, Year = 2004 },
                new UsedCar() { VIN = "C3", Make = "Ford", Model = "Tarus", Price = 7000, Year = 2010 },
                new UsedCar() { VIN = "D4", Make = "Ford", Model = "Escape", Price = 15000, Year = 2014 },
                new UsedCar() { VIN = "E5", Make = "BMW", Model = "55i", Price = 15000, Year = 2015 },
                new UsedCar() { VIN = "Z5", Make = "BMW", Model = "55i", Price = 9000, Year = 2002 },
                new UsedCar() { VIN = "U10", Make = "Toyota", Model = "4Runner", Price = 6500, Year = 2002 },
                new UsedCar() { VIN = "T2", Make = "Toyota", Model = "Camry", Price = 8700, Year = 2011 },
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} is a nice used car that costs: {2:C}", bmw.Year, bmw.Model, bmw.Price);
            }
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("LINQ for cars < 10000");
            var cheapCars = from car in usedCars
                            where car.Price < 10000 && car.Price > 5000 && car.Make == "Toyota"
                            select car;
            foreach (var cheapCar in cheapCars)
            {
                Console.WriteLine("The {0} {1} is a nice cheap car that costs: {2:C}",
                    cheapCar.Year,
                    cheapCar.Model,
                    cheapCar.Price);
            }

            Console.WriteLine("");
            Console.WriteLine("LINQ with Lambda");
            var toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach (var toyota in toyotas)
            {
                Console.WriteLine(toyota.Model);
            }

            var niceUsedCars = usedCars.Where(car => car.Price > 7500 && car.Make == "Ford" || car.Make == "BMW");
            foreach (var niceUsedCar in niceUsedCars)
            {
                Console.WriteLine(niceUsedCar.Model + " " + niceUsedCar.VIN);
            }
            Console.ReadLine();

        }
    }

    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }

}
    
