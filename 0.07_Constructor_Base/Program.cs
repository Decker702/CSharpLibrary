using System;

namespace _0._07_Constructor_Base
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