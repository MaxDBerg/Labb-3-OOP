using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_OOP
{
    internal class Square : Geometry
    {
        public double _side { get; set; }
        public Square()
        {
            _side = 10;
        }
        public override double Area()
        {
            return _side * _side;
        }
    }
}
