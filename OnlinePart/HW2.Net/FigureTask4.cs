namespace HW2.Net
{
    using System;

    public abstract class FigureTask4 : IDrawableTask4
    {
        public int X { get; }

        public int Y { get; }

        public FigureTask4(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine(this);
        }

        public abstract void DrawAll(params IDrawableTask4[] array);
    }
}