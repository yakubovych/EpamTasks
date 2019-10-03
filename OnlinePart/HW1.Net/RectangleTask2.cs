using System;

namespace HW.Net
{
    public class RectangleTask2
    {
        public double lengthX;
        public double lengthY;

        public RectangleTask2(double LeftTopY, double LeftTopX, double RightBottomY, double RightBottomX)
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

        public double Square => (lengthX * lengthY);

        public double Perimetеr => 2 * (lengthX + lengthY);
    }
}