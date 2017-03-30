using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> names = new List<string>
              { 
                  "James", "Paul", "Kenn", "Jenn", "Sheriff" //list is indexed 0, 1, 2, 3, 4
              };
            /* foreach (var name in names) 
             {
                 Console.WriteLine(name);
             }
             names.Add("Devan");//need to proof and add the delete Devan 
             Console.WriteLine("=================");
             foreach (var name in names)
             {
                 Console.WriteLine(names);

                 */
            Console.WriteLine("Lambda expression witrh .ForEach);
                names.ForEach(name => Console.WriteLine(name));
            Console.ReadLine();
        }
    }
}
