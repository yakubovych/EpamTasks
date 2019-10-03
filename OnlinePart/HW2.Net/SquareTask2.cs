namespace HW2.Net
{
    using System;

    public class SquareTask2 : FigureTask2
    {
        public SquareTask2(int x, int y)
            : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine(this);
        }
    }
}