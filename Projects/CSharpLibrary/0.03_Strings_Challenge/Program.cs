using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Bronze Challenge: 
                    Research MSDN docs and lean about working with strings in C#
                    Create examples that show techniques for basic string manipulation
                    show how to concatenate multiple strings, 
                    use composite formating, 
                    show how to use escapes, 
                    and how to manipulate numbers(eg, dollars & commas).
             */

            //Concatenate multiple strings
            /*  string name = "Sue";
              string location = "IndyZoo";
              int age = 22;
              Console.WriteLine("My name is " + name + ". How do you do?  I am " + age + " and I am going to visit the " + location + ".");
              Console.ReadLine();
            */

            //Composite formatting
            /*  string name = "Sue";
              string location = "IndyZoo";
              int age = 22;
              Console.WriteLine("My name is {0}. I'm going to visit the {1} at age {2}.", name, location, age);
              Console.ReadLine();
          */

            //Escaping braces
            /*  int num = 234;
            Console.WriteLine("{{" num "}}");
            Console.ReadLine();
            */

            //TODO - Complete Strings_Challenges
            //Manipulate numbers 
            /*
            decimal dec = 235.00M;
            string money = dec.ToString("C");
            Console.WriteLine(money);
            Console.ReadLine();
            */


            /* Silver Challenge:
                    Create a note to a potential employer that states your goals as a developer.
                    Include the date in the string that is converted to a short date string.
                    */

            //TODO: this is the right place, just need the right order.
            var date = date.ToShortDateString();
           // DateTime date = DateTime.Now;
            //Instance.ToShortDateString()

            var shortDate = date.ToString("MM-dd-yyyy");
            Console.WriteLine(date);





            Console.ReadLine();

            



        /*  Dear Ms. Jones,
          Today is 3/29/2017.  I enjoy the class and learning C#.
          When I complete the course, I would like to get a job as a developer.
          Thank you,
          L. Decker
          */


        /* Gold Challenge:
                Create 2 strings: Your user name in lowercase, and in uppercase,
                Write code that compares the two strings and prints whether or not they are equal.
                Print one sentence that says they are equal.
                Print a second sentence that says they are not equal.

        Dim myString As String = "Alphabetical"
Dim secondString As String = "Order"
Dim result As Integer
result = String.Compare (myString, secondString)
         */

    }
    }
}
