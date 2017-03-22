using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = false;
            bool elevatorStuckWhileWeAreInIt = true;
            int elevatorNumber = 13;

            if(elevatorUp == true)
            {
                //Do stuff
                Console.WriteLine("Going up");
            }
            else
            {
                //Do something else
                Console.WriteLine("Going down");
            }
            if (elevatorBroken)
            {
                Console.WriteLine("Panic!!");
            }
            else
            {
                Console.WriteLine("A working elevator");
            }
            if (elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Let's go Diehard in the elevator shaft!");
                Console.WriteLine("Let's climb up the cord!");
            }
            else
            {
                Console.WriteLine("Do you have the reports for me?");
            }
            if(elevatorBroken && elevatorDown) //both have to be true, due to and (&&)
            {
                Console.WriteLine("Wheeeee!");

            }
            else
            {
                Console.WriteLine("I wish the elevator was broked.  Then would not have to go to the meeting.");
            }
            if (elevatorBroken || elevatorDown) //one has to be, due to or (||)
            {
                Console.WriteLine("Wheeeee!");

            }
            else
            {
                Console.WriteLine("I wish the elevator was broked.  Then would not have to go to the meeting.");
            }



            Console.ReadLine();
        }
    }
}
