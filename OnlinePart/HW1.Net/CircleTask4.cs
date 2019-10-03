namespace HW.Net
{
    public static class CircleTask4
    {
        private const double PI = 3.14;

        public static double Length(double Radius)
        {
            return 2 * PI * Radius;
        }

        public static double Square(double Radius)
        {
            return PI * Radius * Radius;
        }
    }
}