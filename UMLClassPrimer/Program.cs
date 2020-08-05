using System;

namespace UMLClassPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Location location = new Location(4, 5);
            Shape shape = new Shape(location);
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(6, 4);

            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Perimeter());
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.Perimeter());
        }
    }
}
