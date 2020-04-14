using System;
using System.Collections.Generic;

namespace lect11.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            circle circle = new circle(4);
            Square square = new Square(5);
            triangle triangle = new triangle(5,4);

            List<object> listobj = new List<object> { circle, square, triangle };

            foreach (var item in listobj)
            {
                Console.WriteLine($"This is {nameof(item)}. CLR Type is {item.GetType()} Square is {circle.getArea()}");
            }
        }
    }
}
