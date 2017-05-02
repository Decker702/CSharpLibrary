using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {//In an if-else statement, if condition evaluates to true, the then-statement runs.
            //If the condition is false, the else-statement runs.  
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreOnIt = true;
            int elevatorNumber = 13;
            
            if (elevatorUp == true)
            {
                Console.WriteLine("Going up.");
            }
            else
            {
                Console.WriteLine("Going down.");
            }

            if (elevatorBroken)
            {
                Console.WriteLine("Bummer.  Let's take the stairs.");
            }
            else
            {
                Console.WriteLine("Which floor?");
            }

            if (elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("Oh no! We are stuck!");
            }
            else
            {
                Console.WriteLine("This elevator is fast.");
            }

            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("I hope this thing doesn't start flying down!");
            }
            else
            {
                Console.WriteLine("How long are you in town?.");
            }
            if (elevatorBroken || elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("Hi, this is Bob in maintenance.  How can I help you?");
            }
            if (elevatorNumber == 13 && elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("This is not our Lucky Day.");
            }

            Console.ReadLine();


        }
    }
}
