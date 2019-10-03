namespace HW.Net
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1:");
            Task1();
            Console.WriteLine("Task2:");
            Task2();
            Console.WriteLine("Task3:");
            Task3();
            Console.WriteLine("Task4:");
            Task4();
            Console.WriteLine("Task5:");
            Task5();
        }

        public static void Task1()
        {
            Console.Write("LeftY: ");
            double LeftY = Convert.ToDouble(Console.ReadLine());

            Console.Write("LeftX: ");
            double LeftX = Convert.ToDouble(Console.ReadLine());

            Console.Write("RighY: ");
            double RightY = Convert.ToDouble(Console.ReadLine());

            Console.Write("RightX: ");
            double RightX = Convert.ToDouble(Console.ReadLine());

            RectangleTask1 rect = new RectangleTask1(LeftY, LeftX, RightY, RightX);

            Console.WriteLine("Square: {0}; Perimeter: {1};", rect.Square(), rect.Perimetеr());
            Console.ReadKey();
        }

        public static void Task2()
        {
            Console.Write("LeftY: ");
            double LeftY = Convert.ToDouble(Console.ReadLine());

            Console.Write("LeftX: ");
            double LeftX = Convert.ToDouble(Console.ReadLine());

            Console.Write("RightY: ");
            double RightY = Convert.ToDouble(Console.ReadLine());

            Console.Write("RightX: ");
            double RightX = Convert.ToDouble(Console.ReadLine());

            RectangleTask2 rect = new RectangleTask2(LeftY, LeftX, RightY, RightX);

            Console.WriteLine("Square: {0}; Perimeter: {1};", rect.Square, rect.Perimetеr);
            Console.ReadKey();
        }

        public static void Task3()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            CircleTask3 circ = new CircleTask3();

            Console.WriteLine("Length: {0}; Square: {1}", circ.Length(radius), circ.Square(radius));
            Console.ReadKey();
        }

        public static void Task4()
        {
            Console.Write("LeftY: ");
            double LeftY = Convert.ToDouble(Console.ReadLine());

            Console.Write("LeftX: ");
            double LeftX = Convert.ToDouble(Console.ReadLine());

            Console.Write("RighY: ");
            double RightY = Convert.ToDouble(Console.ReadLine());

            Console.Write("RightX: ");
            double RightX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square: {0}; Perimeter: {1};", RectangleTask4.Square(LeftY, LeftX, RightY, RightX), RectangleTask4.Perimeter(LeftY, LeftX, RightY, RightX));

            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Length: {0}; Square: {1};", CircleTask4.Length(radius), CircleTask4.Square(radius));
            Console.ReadKey();
        }

        public static void Task5()
        {
            double real, imaginary;

            ComplexNumberTask5 numb1, numb2 = new ComplexNumberTask5();

            Console.Write("First Real: ");
            real = Convert.ToDouble(Console.ReadLine());

            Console.Write("First Imaginary: ");
            imaginary = Convert.ToDouble(Console.ReadLine());

            numb1 = new ComplexNumberTask5(real, imaginary);

            Console.Write("Second Real: ");
            real = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second Imaginary: ");
            imaginary = Convert.ToDouble(Console.ReadLine());

            numb2 = new ComplexNumberTask5(real, imaginary);

            ComplexNumberTask5 numb3 = numb1 * numb2;

            Console.WriteLine("Multiplication: ");
            Console.WriteLine($"numb3 = {numb3.Real} + i * {numb3.Imaginary}");
            ComplexNumberTask5 numb4 = numb1 / numb2;

            Console.WriteLine("Division: ");
            Console.WriteLine($"numb4 = {numb4.Real} + i * {numb4.Imaginary}");
            Console.ReadKey();
        }
    }
}