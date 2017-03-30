using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  BRONZE CHALLENGE:
                Create a list of value types. (int, string, bool, float, double, decimal)
                Create two examples for each type. One is a declaration only.
                The other is a declaration with initializer.
                Print a view of the values in the console
            */
        /*
            //Declare only
            int number;
            string name;
            bool isValid;
            float number;
            double number;
            decimal number;
        */
            //Declare & Initialize
            int num = 87;
            string dog = "Neko";
            bool isValid = true;
            float f = 8.6f;
            double d = 67.76;
            decimal dd = 9.99m;

            Console.WriteLine(num);
            Console.WriteLine(dog);
            Console.WriteLine(isValid);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(dd);

          //  Console.ReadLine();

            /*SILVER CHALLENGE:
              Use those types to concatenate a string.Any string will do.
            */
            Console.WriteLine("My dog " + dog + " is " + num + " years old.");
            // Console.ReadLine();

            /* GOLD CHALLENGE:
               Declare the year you were born as a string.
               Convert that variable from a string to an integer and print it with a message in the console.
               For instance, "I was born in 1976." */

            string year = "1776";
            int.Parse(year);
            Console.WriteLine("America was born in " + year + ".");
            Console.ReadLine();
        }
    }
}
