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
            var area = square1.calcArea(10);

            Console.WriteLine("The area of square1 is: " + area);
        }
    }
}
