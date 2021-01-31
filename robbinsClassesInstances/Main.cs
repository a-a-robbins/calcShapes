using System;
using System.Collections.Generic;
using System.Text;

namespace robbinsClassesInstances
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            var square1 = new Square(10);
            var rectangle1 = new Rectangle(5, 4);

            Console.WriteLine(); 

            Console.WriteLine("The area of square1 is: " + square1.calcArea(10));
            Console.WriteLine("The perimeter of square1 is: " + square1.calcPerim(10));
            Console.WriteLine("The area of rectangle1 is: " + rectangle1.calcArea(5, 4));
            Console.WriteLine("The perimeter of rectangle1 is: " + rectangle1.calcPerim(5, 4));

        }
    }
}
