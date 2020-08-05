using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClassPrimer
{
    class Circle: Shape
    {
        protected double radius;

        public Circle(double radius)
        : base(new Location(4, 5))
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * radius;
        }

        public override string ToString()
        {
            return " ";
        }
    }
}
