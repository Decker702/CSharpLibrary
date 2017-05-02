using System;
using System.Collections.Generic;
using System.Text;

namespace 0.92_Challenge
{
  
    class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int sides, int length)
        {
            this.NumberOfSides = sides;
            this.SideLength = length;
        }
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        //WUUUUUUT?
        public virtual double GetArea()
        {
            Console.WriteLine("Good morning");
            throw new NotImplementedException();
        }
    }
}