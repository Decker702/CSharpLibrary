using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donuts appleCin = new Donuts();
            appleCin.Filling = "apple pie";
            appleCin.isSpecial = false;
            appleCin.Price = 0.99M;
            appleCin.Type = "Filled";

            Donuts longJohn = new Donuts();
            longJohn.Filling = "Barvarian Cream";
            longJohn.isSpecial = true;
            longJohn.Price = 1.25M;
            longJohn.Type = "Filled";

            Console.WriteLine("A longjohn cost about {0:C}.", longJohn.Price);


           // Console.WriteLine(appleCin.Filling);
            Console.ReadLine();

        }
    }
}
