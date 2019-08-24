using System;

namespace Task_2._1._ClassFigureWithReadonlyProperties
{
    public abstract class Figure
    {
        public abstract void Draw();
        public readonly int X, Y;
        public Figure()
        {
            X = 1;
            Y = 0;
        }
    }
    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am square");
            Console.WriteLine("Coords of square upp left angle is ({0};{1})", X, Y);
        }
    }
    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am rectangle");
            Console.WriteLine("Coords of rectangle upp left angle is ({0};{1})", X, Y);
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