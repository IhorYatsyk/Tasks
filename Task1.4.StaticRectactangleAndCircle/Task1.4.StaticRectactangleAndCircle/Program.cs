using System;

namespace Task1._4.StaticRectactangleAndCircle
{
    static class RectangleAndCircle
    {
        static void Perimetr(int upLeftX, int upLeftY,
            int downRightX, int downRightY, ref int perimetr)
        {
            perimetr = 2 * (downRightX - upLeftX +
                upLeftY - downRightY);
        }
        static void Square(int upLeftX, int upLeftY,
            int downRightX, int downRightY, ref int square)
        {
            square = (downRightX - upLeftX) *
                (upLeftY - downRightY);
        }
        static double Pi = 3.14;
        static void LengthOfCircle(double radius,
            ref double lengthOfCircle)
        {
            lengthOfCircle = 2 * Pi * radius;
        }
        static void Square(double radius,
            ref double squareOfCircle)
        {
            squareOfCircle = Pi * radius *
                radius;
        }
        static void Main(string[] args)
        {
            int upLeftX, upLeftY, downRightX, downRightY, perimetr = 0, square = 0;
            Console.Write("Enter the x-coords of up left angle x = ");
            upLeftX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y-coords of up left angle y = ");
            upLeftY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the x-coords of down right angle x = ");
            downRightX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y-coords of down right angle y = ");
            downRightY = Convert.ToInt32(Console.ReadLine());
            Perimetr(upLeftX, upLeftY, downRightX, downRightY, ref perimetr);
            Console.WriteLine("Perimetr of rectangle is {0}", perimetr);
            Square(upLeftX, upLeftY, downRightX, downRightY, ref square);
            Console.WriteLine("Square of rectangle is {0}", square);
            double radius, lengthOfCircle = 0, squareOfCircle = 0;
            Console.Write("Enter the radius r of the circe r = ");
            radius = Convert.ToDouble(Console.ReadLine());
            LengthOfCircle(radius, ref lengthOfCircle);
            Console.WriteLine("The length of circle is {0}", lengthOfCircle);
            Square(radius, ref squareOfCircle);
            Console.WriteLine("The square of the circle is {0}", squareOfCircle);
            Console.ReadLine();
        }
    }
}