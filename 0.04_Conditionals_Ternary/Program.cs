using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Ternary
{
    class Program
    {//Ternary Operator returns one of two expressions depending on the condition.  
        //It's pattern is   test ? expression1: expression2.  You need the ? and : to make it work.
        static void Main(string[] args)
        {
           //One way to write it
           int num = 10;
           if (num == 7)
                Console.WriteLine("Hey this is number 7");
            else
                Console.WriteLine("Hey this isn't number 7");
        

           //The Ternary Operator says the same thing in just one line.

            Console.WriteLine((num == 7) ? "Hey, this is the number 7" : "This number isn't 7");


            Console.ReadLine();
        }
    }
}
