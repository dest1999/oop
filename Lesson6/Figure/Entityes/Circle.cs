using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProject
{
    internal class Circle : Point
    {
        private int radius;

        public Circle(int Radius, int HorisontalPosition = 0, int VerticalPosition = 0)
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero");
            }
            radius = Radius;
            horisontalPosition = HorisontalPosition;
            verticalPosition = VerticalPosition;
        }

        public double Area() => radius * radius * Math.PI;

        public override string ToString()
        {
            return base.ToString() + $"\nArea is: {Area()}";
        }

        public override void Draw()
        {
            if (IsVisible)
            {
                Console.ForegroundColor = Color;

                for (int i = 1; i < 360; i++)
                {
                    int tmpH = (horisontalPosition + (int)(radius * Math.Cos(i))) * coefficient;
                    int tmpV = verticalPosition + (int)(radius * Math.Sin(i));
                    Console.SetCursorPosition(tmpH, tmpV);
                    Console.Write("*");
                }

                Console.ResetColor();
                string infoString = $"S={Area()}";
                Console.SetCursorPosition(horisontalPosition * coefficient - (infoString.Length / 2), verticalPosition);
                Console.Write(infoString);
                Console.SetCursorPosition(0, radius + verticalPosition);

                (_, int bufferHeight) = Console.GetCursorPosition();
                if (Program.BufferHeight < bufferHeight)
                {
                    Program.BufferHeight = bufferHeight;
                }
            }
        }

    }
}
