using System;
using System.Collections.Generic;

namespace lect11.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Circle circle = new Circle(4);
            Square square = new Square(5);
            Triangle triangle = new Triangle(5,4);
            List<Shape> listobj = new List<Shape> { circle, square, triangle };

            foreach (var item in listobj)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item.GetType()}. Square is {item.GetArea()}");
            } 
        }
    }
}
