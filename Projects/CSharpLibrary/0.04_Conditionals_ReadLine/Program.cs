using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if(feelingNumber == "5")
            {
                Console.WriteLine("Wow, that's great to hear.");
            }
            else if(feelingNumber == "4")
            {
                Console.WriteLine("Good for you.");
            }

            else if (feelingNumber == "3")
            {
                Console.WriteLine("Average is good.");
            }

            else if (feelingNumber == "2")
            {
                Console.WriteLine("Sorry to hear it.");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("How miserable.");
            }
            else
            {
                Console.WriteLine("Sorry, I didn't catch that, man.");
            }
            Console.ReadLine();

        }
    }
   
}
