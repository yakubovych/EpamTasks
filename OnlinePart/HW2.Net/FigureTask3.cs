namespace HW2.Net
{
    using System;

    public class FigureTask3
    {
        int X { get; }

        int Y { get; }

        public FigureTask3(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine(this);
        }
    }
}