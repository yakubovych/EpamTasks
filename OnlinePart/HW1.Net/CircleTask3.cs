namespace HW.Net
{
    public class CircleTask3
    {
        private const double PI = 3.14;

        public double Length(double radius)
        {
            return 2 * PI * radius;
        }

        public double Square(double radius)
        {
            return PI * radius * radius;
        }
    }
}