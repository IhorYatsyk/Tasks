using System;

namespace Task1._3.Circle
{
    class Circle
    {
        const double Pi = 3.14;
        public static double LengthOfCircle(double radius)
        {
            return 2 * Pi * radius;
        }
        public static double SquareOfCircle(double radius)
        {
            return Pi * radius * radius; 
        }
        static void Main(string[] args)
        {
            double lengthOfCircle = LengthOfCircle(1);
            double squareOfCircle = SquareOfCircle(1);
            Console.WriteLine("Length of circle = {0}", lengthOfCircle);
            Console.WriteLine("Square of circle = {0}", squareOfCircle);
            Console.ReadLine();
        }
    }
}
