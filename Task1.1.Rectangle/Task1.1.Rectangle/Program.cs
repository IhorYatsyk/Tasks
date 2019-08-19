using System;

namespace Task1._1.Rectangle
{
    class Rectangle
    {
        int upLeftX, upLeftY, downRightX, downRightY;
        Rectangle(int upLeftX, int upLeftY, int downRightX, int downRightY)
        {
            this.upLeftX = upLeftX;
            this.upLeftY = upLeftY;
            this.downRightX = downRightX;
            this.downRightY = downRightY;
        }
        public static int Perimetr(Rectangle rectangle)
        {
           int result = 2 * (rectangle.downRightX - rectangle.upLeftX +
            rectangle.upLeftY - rectangle.downRightY);
        return result;
        }
        public static int Square(Rectangle rectangle)
        {
            int result = (rectangle.downRightX - rectangle.upLeftX) *
             (rectangle.upLeftY - rectangle.downRightY);
            return result;
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(0, 0, 1, -1);
            Console.WriteLine("Perimetr of rectangle is {0}", Perimetr(rectangle));
            Console.WriteLine("Square of rectangle is {0}", Square(rectangle));
            Console.ReadLine();
        }
    }   
}