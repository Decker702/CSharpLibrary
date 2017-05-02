using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            theJSWizard.AppearsWealthy = false;
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";
            //above we set the properties for the JSWizard

           // Console.WriteLine(); is not needed here, since it is called in the Customer class

            theJSWizard.PrintCustomerName();

            Customer theSherriff = new Customer();
            theSherriff.FirstName = "Sheriff";
            theSherriff.LastName = "Holler";
            theSherriff.PrintCustomerName();

            Customer theTeacher = new Customer();
            theTeacher.FirstName = "Paul";
            theTeacher.LastName = "O'Connor";
            theTeacher.PrintCustomerName();

            Customer Teacher = new Customer();
            Teacher.FirstName = "Ken";
            Teacher.LastName = "Pascascio";
            Teacher.PrintCustomerName();


            Console.ReadLine();


        }
    }
}
