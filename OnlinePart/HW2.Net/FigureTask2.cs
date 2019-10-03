namespace HW2.Net
{
    public abstract class FigureTask2
    {
        int X { get; }

        int Y { get; }

        public FigureTask2(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Draw();
    }
}