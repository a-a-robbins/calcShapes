using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Rectangle
    {
        private double l;
        private double w;

        public Rectangle(double l, double w)
        {
            Console.WriteLine("initializing new Rectangle with length of: " + l + " and width of: " + w);
        }

        public double calcArea(double l, double w)
        {
            return (l * w);
        }

        public double calcPerim(double l, double w)
        { 
            
            return ((2*l) + (2*w));
        }

    }
}
