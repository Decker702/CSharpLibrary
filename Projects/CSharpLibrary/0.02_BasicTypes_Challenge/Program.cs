using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bronze: Create a list of value types
             * Create 2 examples for each type 1) Declaration & 2) Declare & Initilize
             * Print a view of the values in the console
             */
            /*
               // int number;
               int year = 1776;
               //string city;
                string city = "Fishers";
                //bool isOn;
                bool isOn = true;
               // double d;
                double d = 78.76;
                //decimal dd;
                decimal dd = 78.76M;
                Console.WriteLine(year);
                Console.WriteLine(city);
                Console.WriteLine(isOn);
                Console.WriteLine(d);
                Console.WriteLine(dd);
                Console.ReadLine();
                */

            //Silver:  Use the types to concatenate a string
            /* int year = 2017;
             string city = "Fishers";
             Console.WriteLine("I am in " + city + " in " + year +".");
             Console.ReadLine();
             */

            /*Gold: Declare the year you were born in a string
                Convert that variable from a sting to an integer and print it 
                with a message in the console.
            */
           
            int num = int.Parse("1776");
            Console.WriteLine("The USA was born in " + num +".");
            Console.ReadLine();




        }
    }
}
