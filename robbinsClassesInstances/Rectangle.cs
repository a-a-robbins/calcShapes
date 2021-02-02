using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Rectangle : Shape 
    {
        private double h = DefaultSide1;
        private double w = DefaultSide2;

        public Rectangle()
        {
            Console.WriteLine("initializing new Rectangle with height of: " + h + " and width of: " + w);

        }

        public Rectangle(double h, double w)
        {
            Console.WriteLine("initializing new Rectangle with height of: " + h + " and width of: " + w);
        }

        public double calcArea()
        {
            return (h * w); 
        }
        public double calcArea(double h, double w)
        {
            return (h * w);
        }

        public double calcPerim()
        {
            return ((2 * h) + (2 * w)); 
        }
        public double calcPerim(double h, double w)
        { 
            
            return ((2*h) + (2*w));
        }

    }
}
