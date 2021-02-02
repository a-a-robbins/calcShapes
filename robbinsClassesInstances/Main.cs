using System;
using System.Collections.Generic;
using System.Text;


/* Potential Additions: 
*  use shapes superclass with if/switch statements to use 
*  appropriate calculations for area and perimeter, 
*  therefore eliminating need for all of these individual 
*  write statements :) 
*/


namespace robbinsClassesInstances
{
    class MainClass : Shape
    {
        public static void Main(String[] args)
        {

            var square1 = new Square();
            var square2 = new Square(100);
            Console.WriteLine();

            var rectangle1 = new Rectangle(); 
            var rectangle2 = new Rectangle(100, 125);
            Console.WriteLine();

            var circle1 = new Circle(); 
            var circle2 = new Circle(9);
            Console.WriteLine();

            var ellipse1 = new Ellipse();
            var ellipse2 = new Ellipse(20, 15);
            Console.WriteLine();

            var pentagon1 = new Pentagon();
            var pentagon2 = new Pentagon(5, 10);

          
            Console.WriteLine();


            Console.WriteLine("The area of square1 is: " + square1.calcArea());
            Console.WriteLine("The perimeter of square1 is: " + square1.calcPerim());
            Console.WriteLine("The area of square2 is: " + square2.calcArea(100));
            Console.WriteLine("The perimeter of square2 is: " + square2.calcPerim(100));
            Console.WriteLine();

            Console.WriteLine("The area of rectangle1 is: " + rectangle1.calcArea());
            Console.WriteLine("The perimeter of rectangle1 is: " + rectangle1.calcPerim());
            Console.WriteLine("The area of rectangle2 is: " + rectangle2.calcArea(100, 125));
            Console.WriteLine("The perimeter of rectangle2 is: " + rectangle2.calcPerim(100, 125));
            Console.WriteLine();

            Console.WriteLine("The area of circle1 one is: {0:N}", circle1.calcArea());
            Console.WriteLine("The perimeter of circle1 is: {0:N}", circle1.calcPerim());
            Console.WriteLine("The area of circle2 one is: {0:N}", circle2.calcArea(9));
            Console.WriteLine("The perimeter of circle2 is: {0:N}", circle2.calcPerim(9));
            Console.WriteLine();

            Console.WriteLine("The area of ellipse1 is: {0:N}", ellipse1.calcArea());
            Console.WriteLine("The perimeter of ellipse1 is: {0:N}", ellipse1.calcPerim());
            Console.WriteLine("The area of ellipse2 is: {0:N}", ellipse2.calcArea(20, 15));
            Console.WriteLine("The perimeter of ellipse2 is: {0:N}", ellipse2.calcPerim(20, 15));
            Console.WriteLine();

            Console.WriteLine("The area of pentagon1 is: " + pentagon1.calcArea());
            Console.WriteLine("The perimeter of pentagon1 is: " + pentagon1.calcPerim());
            Console.WriteLine("The area of pentagon2 is: " + pentagon2.calcArea(5, 10));
            Console.WriteLine("The perimeter of pentagon2 is: " + pentagon2.calcPerim(5));

        }
    }
}
