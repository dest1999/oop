using System;

namespace FigureProject
{
    internal class Program
    {
        public static int BufferHeight = 0;
        static void Main(string[] args)
        {
            Point point = new();
            point.SetColorTo(ConsoleColor.Green);
            point.Draw();
            point.MoveToPosition(2, 3);
            point.Draw();

            Circle circle = new(10, 10, 14);
            circle.SetColorTo(ConsoleColor.Yellow);
            circle.Visible(true);
            circle.Draw();

            Rectangle rectangle = new(9, 21, 9, 4);
            rectangle.Visible(true);
            rectangle.SetColorTo(ConsoleColor.Gray);
            rectangle.Draw();

            Console.SetCursorPosition(0, BufferHeight);
            Console.WriteLine(point);
            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
        }
    }
}
