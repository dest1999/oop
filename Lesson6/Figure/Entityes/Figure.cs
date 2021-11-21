using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProject
{
    internal abstract class Figure
    {
        public bool IsVisible { get; private set; }
        public ConsoleColor Color { get; private set; }

        protected int horisontalPosition;
        protected int verticalPosition;

        public void MoveToHorisontalPosition(int Position)
        {
            horisontalPosition += Position;
        }

        public void MoveToVerticalPosition(int Position) 
        { 
            verticalPosition += Position;
        }

        public void MoveToPosition(int HorisontalPosition, int VerticalPosition)
        {
            MoveToHorisontalPosition(HorisontalPosition);
            MoveToVerticalPosition(VerticalPosition);
        }

        public void SetColorTo(ConsoleColor Color)
        {
            this.Color = Color;
        }

        public bool Visible() => IsVisible;

        public void Visible(bool Visible)
        {
            IsVisible = Visible;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nColor is: {Color}\nVisibility: {Visible()}\nPosition: {horisontalPosition}, {verticalPosition}";
        }
    }
}
