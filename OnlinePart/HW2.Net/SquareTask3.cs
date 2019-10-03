namespace HW2.Net
{
    using System;

    public class SquareTask3 : FigureTask3
    {
        public SquareTask3(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine(this);
        }
    }
}