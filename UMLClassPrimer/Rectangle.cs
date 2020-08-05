using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClassPrimer
{
    class Rectangle : Shape
    {
        protected double side1;
        protected double side2;

        public Rectangle(double side1, double side2)
        
        :base(new Location(4,5)){
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }

        public override string ToString()
        {
            return " ";
        }
    }
}
