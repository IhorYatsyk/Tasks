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
            Console.Write("Enter the radius of the circle radius = ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Length of circle = {0}", LengthOfCircle(radius));
            Console.WriteLine("Square of circle = {0}", SquareOfCircle(radius));
            Console.ReadLine();
        }
    }
}
