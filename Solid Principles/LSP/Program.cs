using System;

namespace LSP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }
    }

    public abstract class Shape
    {
        public abstract int Area();
    }
    /*public class AreaCalculate
    {
        public static int CalculateRectangle(Rectangles rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static int CalculateSquare(Squares square)
        {
            return square.Height * square.Height;
        }
    }
    */
}
