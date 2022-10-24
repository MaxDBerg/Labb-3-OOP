using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labb_3_OOP
{
    internal class Circle : Geometry
    {
        public double _radius { get; set; }
        public Circle()
        {
            _radius = 10;
        }
        public override double Area()
        {
            return Math.Pow(_radius, 2) * _pi;
        }
    }
}
