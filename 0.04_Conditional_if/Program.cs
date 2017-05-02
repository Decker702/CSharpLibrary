using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_if
{
    class Program
    {
        static void Main(string[] args)
        {  //If statement identifies which statment to run based on the value of a Boolean expression.
            bool isOn = true;
            bool isHot = false;
          
            if (isOn)
            {
                Console.WriteLine("The light is on.  It is bright.");
            }
            if (isOn == true)//Operator == tests for equality; while = is variable assignment
            {
                Console.WriteLine("The light is on.");
            }
            if (isOn && isHot)//Operator && is conditional for and; both have to be true
            {
                Console.WriteLine("Lights are on and it's hot.");
            }
            if (isOn || isHot)//Operator || is conditional for or; either have to be true
                //System tests the first statement and if true it moves on, if false it test the second one.
            {
                Console.WriteLine("Lights are on or it is hot.");
            }
            if (isHot)
            {
                Console.WriteLine("it is not hot.");
            }

            Console.ReadLine();
        }
    }
}
