using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_AccessModiifiers
{
    
   /*   public class Car
      {
 -        //Noitice that this private int can't be accessed outside of the class.
 -        private int actualCost = 50000;
 -        public int customerPrice;
 +        //Protected allows our properties only accessible to our child classes.
 +        protected string Make { get; set; }
 +        protected string Model { get; set; }
 +        protected int Year { get; set; }
  
 -        public string name { get; set; }
 -
 -        public void CalculateGain()
 +        public string CarDetails()
          {
 -            int gain = customerPrice - actualCost;
 -            if (gain >= 25000)
 -            {
 -                Console.WriteLine("This would be a good customer price for this car.");
 -            }
 -            else
 -            {
 -                Console.WriteLine("That price is too low for us to make a profit.");
 -            }
 +            return $"Make: {Make}\nModel: {Model}\nYear: {Year}";
 +        }
 +
 +    }
  
 +    public class Acura : Car
 +    {
 +        //The private protects our variable from being changed without creating an object
 +        private int price;
 +        public Acura(string model, int year, int price = 20000)
 +        {
 +            this.Make = "Acura";
 +            this.Model = model;
 +            this.Year = year;
 +            this.price = price;
          }
  
 +        public void AcuraDetails()
 +        {
 +            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nPrice: {price}");
 +        }
     
 
*/