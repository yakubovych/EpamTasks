namespace HW.Net
{
    public class RectangleTask1
    {
        public double lengthX;
        public double lengthY;

        public RectangleTask1(double LeftTopY, double LeftTopX, double RightBottomY, double RightBottomX)
        {
            this.lengthX = LeftTopX - RightBottomX;
            if (lengthX < 0)
            {
                lengthX = lengthX * (-1);
            }

            this.lengthY = LeftTopY - RightBottomY;
            if (lengthY < 0)
            {
                lengthY = lengthY * (-1);
            }
        }

        public double Square()
        {
            return lengthX * lengthY;
        }

        public double Perimetеr()
        {
            return 2 * (lengthX + lengthY);
        }
    }
}