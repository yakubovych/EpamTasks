namespace HW2.Net
{
    using System;

    public class RectangleTask4 : FigureTask4
    {
        public RectangleTask4(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine(this);
        }

        public override void DrawAll(params IDrawableTask4[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
}