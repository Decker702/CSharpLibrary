using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Demo
            string firstName;
            string lastName;
            string occupation;

            firstName = "Charlie";
            lastName = "Brown";
            occupation = "Stuntman";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //String Interpolation
            Console.WriteLine("Name: {0} \n Occupation: {1}\n {2}",
            fullName,
            occupation,
            "Paul"
            );
            //String Interpolation
            Console.WriteLine("{0:C}",100.736);



            /*  Bronze Challenge:
             *  Try to show how to concatenate multiple strings, 
             *  use composite formating, 
             *  show how to use escapes, 
             *  and how to manipulate numbers(eg, dollars &commas).*/

           


            Console.ReadLine();


        }
    }
}
