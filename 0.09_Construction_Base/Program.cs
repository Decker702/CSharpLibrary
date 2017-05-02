using System;

namespace _0._09_Construction_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            //set properties
            Person kenn = new Person();
            kenn.FirstName = "Kenn";
            kenn.LastName = "Pasciao";
            kenn.age = 25;
            kenn.TestMethod();

            //Using constructor 2.  It is dry, since don't have to repeat yourself
            Person kenn2 = new Person("Kenny", "Pascasciao", 40);

            Minor sophia = new Minor  = new Minor("Sophia", "O'Connor", 4, true);
            //I have a problem with connecting to minor
            sophia.DemoMethod();//only in minor class, can't call from Person class
            sophia.TestMethod();

            Person jenn = new Minor("Jenn", "Aikins", 17, true);
            jenn.TestMethod();

            Console.WriteLine();
        }
    }
}
/* Paul slacked this out
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using construtor 1
            Person kenn = new Person();
            kenn.FirstName = "Kenn";
            kenn.LastName = "Pascascio";
            kenn.Age = 40;
            kenn.TestMethod();

            //Using constructor 2
            Person kenn2 = new Person("Kenny", "Pascascio", 40);
            kenn2.TestMethod();
            
            Minor sophia = new Minor("Sophia", "O'Connor", 4, true);
            sophia.DemoMethod();
            sophia.TestMethod();

            Person jenn = new Minor("Jenn", "Aikins", 17, true);
            jenn.TestMethod();


            Minor jennA = new Minor("Jenn", "Aikins", 16, true);
            jennA.DemoMethod();
            jennA.TestMethod();

            Console.ReadLine();







            //Person chris = new Person("Chris", "Sullivan");
            //chris.TestMethod();

    */


