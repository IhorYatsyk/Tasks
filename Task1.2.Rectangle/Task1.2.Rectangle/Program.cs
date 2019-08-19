using System;

namespace Task1._2.Rectangle
{
    class Rectangle
    {
        public int upLeftX { get; set; }
        public int upLeftY { get; set; }
        public int downRightX { get; set; }
        public int downRightY { get; set; }
        public int Perimetr { get; set; }
        public int Square { get; set; }
        
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Enter the x-coords of up left angle x = ");
            rectangle.upLeftX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y-coords of up left angle y = ");
            rectangle.upLeftY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the x-coords of down right angle x = ");
            rectangle.downRightX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y-coords of down right angle y = ");
            rectangle.downRightY = Convert.ToInt32(Console.ReadLine());
            rectangle.Perimetr = 2 * (rectangle.downRightX - rectangle.upLeftX + rectangle.upLeftY - rectangle.downRightY);
            rectangle.Square = (rectangle.downRightX - rectangle.upLeftX) * (rectangle.upLeftY - rectangle.downRightY);
            Console.WriteLine("Perimetr of rectangle is {0}", rectangle.Perimetr);
            Console.WriteLine("Square of rectangle is {0}", rectangle.Square);
            Console.ReadLine();
        }
    }
}