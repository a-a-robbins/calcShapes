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
            var circle1 = new Circle(3);
            var ellipse1 = new Ellipse(2, 3);
            var pentagon1 = new Pentagon(5, 10); 

            Console.WriteLine(); 

            Console.WriteLine("The area of square1 is: " + square1.calcArea(10));
            Console.WriteLine("The perimeter of square1 is: " + square1.calcPerim(10));
            Console.WriteLine("The area of rectangle1 is: " + rectangle1.calcArea(5, 4));
            Console.WriteLine("The perimeter of rectangle1 is: " + rectangle1.calcPerim(5, 4));
            Console.WriteLine("The area of circle1 one is: " + circle1.calcArea(3));
            Console.WriteLine("The perimeter of circle1 is: " + circle1.calcPerim(3));
            Console.WriteLine("The area of ellipse1 one is: " + ellipse1.calcArea(2, 3));
            Console.WriteLine("The perimeter of ellipse1 is: " + ellipse1.calcPerim(2, 3));
            Console.WriteLine("The area of pentagon1 one is: " + pentagon1.calcArea(5, 10));
            Console.WriteLine("The perimeter of pentagon1 is: " + ellipse1.calcPerim(5, 10));

        }
    }
}
