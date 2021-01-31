using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class Square : Shape
    {
        private double sideLength;  

        public Square(double s)
        {
            Console.WriteLine("Initializing new Square with side length of: ", s);
            // this.s = s; 
        }

    }
}
