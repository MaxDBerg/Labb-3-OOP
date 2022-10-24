using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_OOP
{
    internal class Rectangle : Geometry
    {
        public double _width { get; set; }
        public double _height { get; set; }
        public Rectangle()
        {
            _width = 5;
            _height = 10;
        }
        public override double Area()
        {
            return _width * _height;
        }
    }
}
