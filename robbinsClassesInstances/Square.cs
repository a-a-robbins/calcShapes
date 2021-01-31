using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Square : Shape
    {
        private double s;  

        public Square(double s)
        {
            Console.WriteLine("Initializing new Square with side length of: ", s);
            // this.s = s; 
        }

        public double calcArea(double s)
        {
            return (s * s); 
        }

        public double calcPerim(double s)
        {
            return (s * 4); 
        }

    }
}
