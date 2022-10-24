using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_OOP
{
    abstract class Geometry
    {
        public double _pi { get; set; }
        public Geometry()
        {
            _pi = 3.1415;
        }
        public abstract double Area();
    }
}
