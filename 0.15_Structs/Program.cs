using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Address = "123 Coder Place",
                City = "Westfield",
                State = "IN",
                Zip = "44056",
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = 40
            };
            AddressBookEntry Sue = new AddressBookEntry()
            {
                Address = "987 Coder Street",
                City = "Westfield",
                State = "IN",
                Zip = "44056",
                FirstName = "Sue",
                LastName = "Pickles",
                Age = 30
            };
            AddressBookEntry Jon = new AddressBookEntry()
            {
                Address = "999 Main Street",
                City = "Indy",
                State = "IN",
                Zip = "46220",
                FirstName = "Jon",
                LastName = "Atz",
                Age = 78

            }; AddressBookEntry Tom = new AddressBookEntry()
            {
                Address = "234 Garden Grove",
                City = "San Fran",
                State = "CA",
                Zip = "66666",
                FirstName = "Tom",
                LastName = "Thumb",
                Age = 400
            };



            Console.WriteLine(Paul.GetAddress());
            Console.WriteLine(Sue.GetAddress());
            Console.WriteLine(Jon.GetAddress());
            Console.WriteLine(Tom.GetAddress());
            Console.ReadLine();
        }
        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;

            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\n{Zip}\n";
            }
            
        }
    }
}
//"First Name: {FirstName}\nLast Name: {LastName}\Age: {Age}
//
 /* 
Classes & Structs
 *  A class and a struct define the template for an object
 *  A class references a reference type; All in one box
 *  A struct references a value type; In individual boxes
 *  Reference and value imply memory strategies
 When to Use Structs
 *  Use if: 1) Instances of type are small; 2) The struct is commonly embedded in another type;
    3) The struct logically represents a single value; and 4) The vaules don't change (immutable).
 * Note: structs can have performance benefits in computational intensive applications.
 */
