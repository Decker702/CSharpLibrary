using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Customer
    {

        // Order in writing us 1) FIELDS, 2) Properties, then 3) Methods
        //PROPERTIES
        //following are properties, and they are inside of classes
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool AppearsWealthy { get; set; }
        public decimal BankRoll { get; set; }

        //camel case - use it for variables
        //string firstName

        //Pascal Casing - use for properties
        //public string FullName { get; set; }

        //METHODS - have active verbs ie. Writeline
        //public allows you to use it in another class
        public void PrintCustomerName()
        {
            Console.WriteLine("Hello, {0} {1}", FirstName, LastName);
        }
        public void AssessWealth()
        {
            if (AppearsWealthy)
            {
                Console.WriteLine("He looks loaded.");
            }
            else
            {
                Console.WriteLine("Did you see that car?");
                
    /******Keyword***************Applicable To***************Meaning******************************************		
             public 			    Class, Member			No restrictions
             protected			    Member					Access limited to the class and derived classes
             private		        Member					Access limited to the class.

             internal               Class, Member			Access limited to the current assembly		
            protected internal 	    Member					Access limited to current assembly and derived types

**********************************************************************************************************/



            }
        }

    }
}
