using System;
using System.Collections.Generic;
using System.Text;

namespace 0.09_Construction_Base
{
    class Person
{


    //Constructors go above the properties.  Type ctor tab tab to get default constructor
    //looks like a method, but doesn;'t have a key word for a return.
    //constructor & class have same name.  Constructor has ();

    //You can overload constructors
    public Person()
    {

    }

    //This is a custom constructor using the properties
    // It sets up the arguments
    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = FirstName;
        this.LastName = lastName;
        this.Age = age;
    }
    //Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    public void TestMethod()
    {
        Console.WriteLine("Test Method in Person class.");
    }
}
/*  Paul slacked this outusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    public class Person
    {

        public Person()
        {
                    
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


      

        //Methods
        public virtual void TestMethod()
        {
            Console.WriteLine("Demo method in Person class");
        }
    }
}
*/
 *  
 *  