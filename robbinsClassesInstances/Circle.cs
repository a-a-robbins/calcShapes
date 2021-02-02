using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Circle : Shape
    {
        private double r = DefaultRadius;
        
        public Circle()
        {
            Console.WriteLine("initializing new Circle with radius of: " + r);

        }

        public Circle(double r)
        {
            Console.WriteLine("initializing new Circle with radius of: " + r);

        }

        public double calcArea()
        {
            return (Math.PI * Math.Pow(r, 2)); 
        }
        public double calcArea(double r)
        {
            return (Math.PI * Math.Pow(r, 2)); 
        }

        public double calcPerim()
        {
            return (2 * Math.PI * r); 
        }
        public double calcPerim(double r)
        {
            return (2 * Math.PI * r);
        }
    }
}
