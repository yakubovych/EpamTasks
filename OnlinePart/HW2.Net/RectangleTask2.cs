namespace HW2.Net
{
    using System;

    public class RectangleTask2 : FigureTask2
    {
        public RectangleTask2(int x, int y)
            :base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine(this);
        }
    }
}