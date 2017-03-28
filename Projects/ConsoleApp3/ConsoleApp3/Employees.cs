using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employees
    {
        //Name gets and sets name.
        //below is a field
        private string name;
        // below is a property
        public string Name {
            //get will return the value name & set will allow you to store value.
            get { return name;}
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The Employee name is not valid.");
                Name = value;}
        }

        private int _id;
       
        public int Id
        {
            get { return _id; }
            //don't want a zero or negative id number
            set {
                if (Id <= 0)
                    throw new Exception("The Employee ID is not valid.");
                _id = value; }


        }
}
