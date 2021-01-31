using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Rectangle
    {
        private double h;
        private double w;

        public Rectangle(double h, double w)
        {
            Console.WriteLine("initializing new Rectangle with height of: " + h + " and width of: " + w);
        }

        public double calcArea(double h, double w)
        {
            return (h * w);
        }

        public double calcPerim(double h, double w)
        { 
            
            return ((2*h) + (2*w));
        }

    }
}
