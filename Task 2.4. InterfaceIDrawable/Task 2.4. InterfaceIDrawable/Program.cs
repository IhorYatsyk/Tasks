using System;

namespace Task_2._4._InterfaceIDrawable
{
    interface IDrawable
    {
        void Draw();
    }

    public class Figure : IDrawable
    {
        public int X, Y;
        public void Draw()
        {
            Console.WriteLine("I am a figure");
            Console.WriteLine("Coords of a figure upp left angle is ({0};{1})", X, Y);
        }
    }
    public class Square : IDrawable
    {
        public int X, Y;
        public void Draw()
        {
            Console.WriteLine("I am a square");
            Console.WriteLine("Coords of square upp left angle is ({0};{1})", X, Y);
        }
    }
    public class Rectangle : IDrawable
    {
        public int X, Y;
        public void Draw()
        {
            Console.WriteLine("I am a rectangle");
            Console.WriteLine("Coords of rectangle upp left angle is ({0};{1})", X, Y);
        }
    }
    public class Program
    {
        static void Main()
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
            DrawAll(figure, square, rectangle);
            Console.ReadLine();
        }
        private static void DrawAll(params IDrawable[] args)
        {
            Console.WriteLine("Summary. Draw all figures.");
            foreach (var item in args)
            {
                item.Draw();
            }
        }
    }
}