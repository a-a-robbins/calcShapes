using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Square : Shape
    {
        private double s = DefaultSide1;  

        public Square()
        {
            Console.WriteLine("Initializing new Square with side length of: " + s);
        }
        public Square(double s)
        {
            Console.WriteLine("Initializing new Square with side length of: " + s);
        }

        public double calcArea()
        {
            return (s * s); 
        }
        public double calcArea(double s)
        {
            return (s * s); 
        }

        public double calcPerim()
        {
            return (s * 4); 
        }

        public double calcPerim(double s)
        {
            return (s * 4); 
        }

        ~Square()
        {
            Console.WriteLine("The Garbage Collector has come...destroying instance of Square with side length: " + s);
        }
    }
}
