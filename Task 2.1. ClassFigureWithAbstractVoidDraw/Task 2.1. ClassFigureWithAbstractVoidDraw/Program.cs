using System;

namespace Task_2._1._ClassFigureWithAbstractVoidDraw
{
    public abstract class Figure
    {
        public abstract void Draw();
    }
    public class Square : Figure
    {
        public override void Draw()
        {
           Console.WriteLine("I am square");
        }
    }
    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am rectangle");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Square square = new Square();
            square.Draw();
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            Console.ReadLine();
        }
    }
}
