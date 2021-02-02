using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Ellipse : Shape
    {
        private double a1 = DefaultAxis1;
        private double a2 = DefaultAxis2; 

        public Ellipse()
        {
            Console.WriteLine("initializing new Ellipse with axis lengths of: " + a1 + " and " + a2);

        }
        public Ellipse(double a1, double a2)
        {
            Console.WriteLine("initializing new Ellipse with axis lengths of: " + a1 + " and " + a2);  
        }

        public double calcArea(double a1, double a2)
        {
            return (Math.PI * a1 * a2); 
        }

        public double calcArea()
        {
            return (Math.PI * a1 * a2); 
        }

        public double calcPerim()
        {
            return (Math.PI * (3 * (a1 + a2) - Math.Sqrt((3 * a1 + a2) * (a1 + 3 * a2))));

                
        }

        public double calcPerim(double a1, double a2)
        {
            return (Math.PI * (3 * (a1 + a2) - Math.Sqrt((3 * a1 + a2) * (a1 + 3 * a2)))); 
            
        }

    }
}
