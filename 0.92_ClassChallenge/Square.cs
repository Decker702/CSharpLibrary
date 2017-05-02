using System;
using System.Collections.Generic;
using System.Text;

namespace 0.92_Challenge

{
    class Square : ConcreteRegularPolygon
    {
        //Constructor
        public Square(int length) : base(4, length) { }

        public override double GetArea()
        {
            //base?
            return base.GetArea();
        }
    }

