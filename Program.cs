using System;

namespace Labb_3_OOP
{
    internal class Program
    {
        static void Main()
        {
            var geoCircle = new Circle();
            var geoSquare = new Square();
            var geoRectangle = new Rectangle();
            Console.WriteLine("Circle Area: {0}", geoCircle.Area());
            Console.WriteLine("Square Area: {0}", geoSquare.Area());
            Console.WriteLine("Rectangle Area: {0}", geoRectangle.Area());
        }
    }
}
