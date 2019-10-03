namespace OfflineHomework.FirstTraining.Task2
{
    public struct Rectangle: ISize, ICoordinates
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
