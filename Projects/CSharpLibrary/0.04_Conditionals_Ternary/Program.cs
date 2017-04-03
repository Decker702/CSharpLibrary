using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int num = 10;
           if (num == 7)
                Console.WriteLine("Hey this is number 7");
            else
                Console.WriteLine("Hey this isn't number 7");

            //Ternary Operator

            Console.WriteLine((num == 7) ? "Hey, this is the number 7" : "This number isn't 7");
            //Using a string of name check to see if your name is the same as your neighbors, return a message if it iS
            //return another message if it is not.


            Console.ReadLine();
        }
    }
}
