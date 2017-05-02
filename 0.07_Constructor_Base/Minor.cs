using System;
using System.Collections.Generic;
using System.Text;

namespace 0.07_Constructor_Base
{
    class Minor : Person
    {
    //base keyword calls up to the parent constructor
    public Minor (string firstName, string lastName, int age, bool IsInSchool) 
        : base(firstName, lastName, age) //this in inherited from the parent
    {

    }

    //Property
    public bool IsInSchool { get; set; }

    //Methods
    //virtual in parent class, override in child class
    public void DemoMethod()
    {

    }
    public override void TestMethod()
    {
        Console.WriteLine("Demo method in Minor class.");
    }

    }
}
