namespace HW.Net
{
    public static class RectangleTask4
    {
        public static double lengthX = 0;
        public static double lengthY = 0;

        private static void LengthSide(double LeftTopY, double LeftTopX, double RightBottomY, double RightBottomX)
        {
            lengthX = LeftTopX - RightBottomX;
            if (lengthX < 0)
            {
                lengthX = lengthX * (-1);
            }
            lengthY = LeftTopY - RightBottomY;
            if (lengthY < 0)
            {
                lengthY = lengthY * (-1);
            }
        }

        public static double Perimeter(double LeftTopY, double LeftTopX, double RightBottomY, double RightBottomX)
        {
            LengthSide(LeftTopY, LeftTopX, RightBottomY, RightBottomX);
            return 2 * (lengthX + lengthY);
        }

        public static double Square(double LeftTopY, double LeftTopX, double RightBottomY, double RightBottomX)
        {
            LengthSide(LeftTopY, LeftTopX, RightBottomY, RightBottomX);
            return lengthX * lengthY;
        }
    }
}