namespace HW2.Net
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
        }

        private static void Task1()
        {
            RectangleTask1 r = new RectangleTask1();
            r.Draw();

            SquareTask1 s = new SquareTask1();
            s.Draw();

            Console.ReadKey();
        }

        private static void Task2()
        {
            RectangleTask2 r = new RectangleTask2(x: 5, y: 3);
            r.Draw();

            SquareTask2 s = new SquareTask2(x: 5, y: 3);
            s.Draw();

            Console.ReadKey();
        }

        private static void Task3()
        {
            FigureTask3 f = new FigureTask3(x: 5, y: 3);
            f.Draw();

            RectangleTask3 r = new RectangleTask3(x: 5, y: 3);
            r.Draw();

            SquareTask3 s = new SquareTask3(x: 5, y: 3);
            s.Draw();

            Console.ReadKey();
        }

        private static void Task4()
        {
            RectangleTask4 r = new RectangleTask4(x: 5, y: 3);
            SquareTask4 s = new SquareTask4(x: 5, y: 3);

            r.DrawAll(r, s);

            Console.ReadKey();
        }
    }
}