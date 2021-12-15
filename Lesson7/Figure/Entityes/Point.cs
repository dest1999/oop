using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProject
{
    internal class Point : Figure, IArea
    {
        protected static int coefficient = 2;//поправка для приведения "консольного пикселя" к квадрату

        public virtual double Area()
        {
            return 0;
        }

        public virtual void Draw()
        {
            if (IsVisible)
            {
                Console.SetCursorPosition(horisontalPosition, verticalPosition);
                Console.ForegroundColor = Color;
                Console.WriteLine("*");
                Console.ResetColor();
            }
        }

    }
}
