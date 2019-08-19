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
            rectangle.upLeftX = 0;
            rectangle.upLeftY = 0;
            rectangle.downRightX = 1;
            rectangle.downRightY = -1;
            rectangle.Perimetr = 2 * (rectangle.downRightX - rectangle.upLeftX + rectangle.upLeftY - rectangle.downRightY);
            rectangle.Square = (rectangle.downRightX - rectangle.upLeftX) * (rectangle.upLeftY - rectangle.downRightY);
            Console.WriteLine("Perimetr of rectangle is {0}", rectangle.Perimetr);
            Console.WriteLine("Square of rectangle is {0}", rectangle.Square);
            Console.ReadLine();
        }
    }
}