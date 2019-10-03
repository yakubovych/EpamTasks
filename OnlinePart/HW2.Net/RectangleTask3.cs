namespace HW2.Net
{
    using System;

    public class RectangleTask3 : FigureTask3
    {
        public RectangleTask3(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine(this);
        }
    }
}