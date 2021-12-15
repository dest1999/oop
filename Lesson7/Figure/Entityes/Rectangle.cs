using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProject
{
    internal class Rectangle : Point, IArea
    {
        private int height;
        private int width;

        public Rectangle(int Height, int Width, int HorisontalPosition = 0, int VerticalPosition = 0)
        {
            if (Height < 0 || Width < 0)
            {
                throw new ArgumentException("Dimensions must be not less than zero");
            }

            height = Height;
            width = Width;
            horisontalPosition = HorisontalPosition;
            verticalPosition = VerticalPosition;
        }

        public override double Area() => height * width;

        public override string ToString()
        {
            return base.ToString() + $"\nArea is: {Area()}";
        }

        public override void Draw()
        {
            if (IsVisible)
            {
                Console.SetCursorPosition(horisontalPosition, verticalPosition);
                Console.ForegroundColor = Color;

                for (int raw = 0; raw < height; raw++)
                {
                    if (raw == 0 || raw == height - 1)
                    {
                        for (int col = 0; col < width * coefficient; col++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(horisontalPosition, verticalPosition + raw);
                        Console.Write("*");
                        Console.SetCursorPosition(horisontalPosition + (width * coefficient) - 1, verticalPosition + raw);
                        Console.Write("*");
                        Console.SetCursorPosition(horisontalPosition, verticalPosition + raw + 1);
                    }
                }

                Console.ResetColor();
                string infoString = $"S={Area()}";
                Console.SetCursorPosition((horisontalPosition + width)  - (infoString.Length / 2), verticalPosition + height / 2);
                Console.Write(infoString);
                Console.SetCursorPosition(0, height + 1);

                (_, int bufferHeight) = Console.GetCursorPosition();
                if (Program.BufferHeight < bufferHeight)
                {
                    Program.BufferHeight = bufferHeight;
                }
            }
        }
    }
}
