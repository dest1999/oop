using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProject
{
    internal class Point : Figure
    {
        protected static int coefficient = 2;//поправка для приведения "консольного пикселя" к квадрату

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
