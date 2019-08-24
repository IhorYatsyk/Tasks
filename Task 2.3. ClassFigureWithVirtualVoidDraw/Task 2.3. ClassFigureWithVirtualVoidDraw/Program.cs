using System;

namespace Task_2._3._ClassFigureWithVirtualVoidDraw
{
    public class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a figure");
            Console.WriteLine("Coords of a figure upp left angle is ({0};{1})", X, Y);
        }
        public int X, Y;
    }
    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am a square");
            Console.WriteLine("Coords of square upp left angle is ({0};{1})", X, Y);
        }
    }
    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am a rectangle");
            Console.WriteLine("Coords of rectangle upp left angle is ({0};{1})", X, Y);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Figure figure = new Figure();
            Console.Write("Enter the x-coords of the upp left angle of the figure x = ");
            figure.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y-coords of the upp left angle of the figure y = ");
            figure.Y = Convert.ToInt32(Console.ReadLine());
            figure.Draw();
            Square square = new Square();
            Console.Write("Enter the x-coords of the upp left angle of the square x = ");
            square.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y-coords of the upp left angle of the square y = ");
            square.Y = Convert.ToInt32(Console.ReadLine());
            square.Draw();
            Rectangle rectangle = new Rectangle();
            Console.Write("Enter the x-coords of the upp left angle of the rectangle x = ");
            rectangle.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y-coords of the upp left angle of the rectangle y = ");
            rectangle.Y = Convert.ToInt32(Console.ReadLine());
            rectangle.Draw();
            Console.ReadLine();
        }
    }
}