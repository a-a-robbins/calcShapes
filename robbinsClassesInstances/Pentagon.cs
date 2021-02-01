using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Pentagon : Shape
    {
        private double s;
        private double a; 

        public Pentagon(double s, double a)
        {
            Console.WriteLine("initializing new Pentagon with side length: " + s + " and apothem length: " + a) ;
        }

        public double calcArea(double s, double a)
        {
            double p = calcPerim(s);

            return (p / a) * 2; 
        }
        public double calcPerim(double s)
        {
            return (5 * s); 
        }
    }
}
