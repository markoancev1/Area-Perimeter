using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClassPrimer
{
    class Shape
    {
        protected Location c;

        public Shape(Location c)
        {
            this.c = new Location(4, 5);
        }

        public virtual string ToString()
        {
            return "yes";
        }

        public virtual double Area() {return 0;}
        public virtual double Perimeter() { return 0; }
    }
}
