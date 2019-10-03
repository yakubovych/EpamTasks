namespace HwOutput
{
    using System;
    using System.Collections.Generic;
    using HW1 = HW.Net;
    using HW2 = HW2.Net;
    using HW3 = HW3.Net;

    class Program
    {
        public static object ConverToInt32 { get; private set; }

        public static bool CheckTasks;

        static void Main(string[] args)
        {
            Console.WriteLine("-----Online part tasks-----");

            while (!CheckTasks)
            {
                Console.WriteLine("Select an action: \n" +
                    "(1)  Check first homework;\n" +
                    "(2)  Check second homework;\n" +
                    "(3)  Check third homework;\n" +
                    "(0)  Exit;\n" +
                    "(clear)  Clear console.\n");

                Console.WriteLine("What action do you choose?");
				
                string index = Console.ReadLine();

                switch (index)
                {
                    case "1":
                        Console.Clear();
                        Hw1();
                        break;
                    case "2":
                        Console.Clear();
                        Hw2();
                        break;
                    case "3":
                        Console.Clear();
                        Hw3();
                        break;
                    case "0":
                        CheckTasks = true;
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Input error!");
                        break;
                }
            }
        }

        public static void Hw1()
        {
            Console.WriteLine("\n----- HomeWork 1 -----");
            Console.WriteLine("\n--- Task1 Rectangle ---");

            Console.Write("LeftY: ");
            double LeftY = Convert.ToDouble(Console.ReadLine());

            Console.Write("LeftX: ");
            double LeftX = Convert.ToDouble(Console.ReadLine());

            Console.Write("RighY: ");
            double RightY = Convert.ToDouble(Console.ReadLine());

            Console.Write("RightX: ");
            double RightX = Convert.ToDouble(Console.ReadLine());

            HW1.RectangleTask1 rect1 = new HW1.RectangleTask1(LeftY, LeftX, RightY, RightX);

            Console.WriteLine("Square: {0}; Perimeter: {1};", rect1.Square(), rect1.Perimetеr());

            Console.WriteLine("\n--- Task2 Rectangle ---");

            HW1.RectangleTask2 rect2 = new HW1.RectangleTask2(LeftY, LeftX, RightY, RightX);

            Console.WriteLine("Square: {0}; Perimeter: {1};", rect2.Square, rect2.Perimetеr);

            Console.WriteLine("\n--- Task3 Circle ---");
            Console.Write("Radius: ");
            double radius3 = Convert.ToDouble(Console.ReadLine());

            HW1.CircleTask3 circ = new HW1.CircleTask3();

            Console.WriteLine("Length: {0}; Square: {1}", circ.Length(radius3), circ.Square(radius3));

            Console.WriteLine("--- Task4 Rectangle ---");
            Console.Write("LeftY: ");
            double LeftY4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("LeftX: ");
            double LeftX4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("RighY: ");
            double RightY4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("RightX: ");
            double RightX4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square: {0}; Perimeter: {1};", HW1.RectangleTask4.Square(LeftY4, LeftX4, RightY4, RightX4), HW1.RectangleTask4.Perimeter(LeftY4, LeftX4, RightY4, RightX4));

            Console.WriteLine("--- Task4 Circle ---");
            Console.Write("Radius: ");
            double radius4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Length: {0}; Square: {1};", HW1.CircleTask4.Length(radius4), HW1.CircleTask4.Square(radius4));

            Console.WriteLine("--- Task5 Complex Number ---");

            double real, imaginary;

            HW1.ComplexNumberTask5 numb1, numb2 = new HW1.ComplexNumberTask5();

            Console.Write("First Real: ");
            real = Convert.ToDouble(Console.ReadLine());

            Console.Write("First Imaginary: ");
            imaginary = Convert.ToDouble(Console.ReadLine());

            numb1 = new HW1.ComplexNumberTask5(real, imaginary);

            Console.Write("Second Real: ");
            real = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second Imaginary: ");
            imaginary = Convert.ToDouble(Console.ReadLine());

            numb2 = new HW1.ComplexNumberTask5(real, imaginary);

            HW1.ComplexNumberTask5 numb3 = numb1 * numb2;

            Console.WriteLine("Multiplication: ");
            Console.WriteLine($"numb1 = {numb3.Real} + i * {numb3.Imaginary}");
            HW1.ComplexNumberTask5 numb4 = numb1 / numb2;

            Console.WriteLine("Division: ");
            Console.WriteLine($"numb2 = {numb4.Real} + i * {numb4.Imaginary}");
        }

        private static void Hw2()
        {
            Console.WriteLine("\n----- HomeWork 2 -----");
            Console.WriteLine("\n--- Task1 ---");

            HW2.RectangleTask1 r = new HW2.RectangleTask1();
            r.Draw();

            HW2.SquareTask1 s = new HW2.SquareTask1();
            s.Draw();
            Console.WriteLine();

            Console.WriteLine("\n--- Task2 ---");

            HW2.RectangleTask2 r2 = new HW2.RectangleTask2(x: 5, y: 3);
            r2.Draw();

            HW2.SquareTask2 s2 = new HW2.SquareTask2(x: 5, y: 3);
            s2.Draw();
            Console.WriteLine();

            Console.WriteLine("\n--- Task3 ---");

            HW2.FigureTask3 f3 = new HW2.FigureTask3(x: 5, y: 3);
            f3.Draw();

            HW2.RectangleTask3 r3 = new HW2.RectangleTask3(x: 5, y: 3);
            r3.Draw();

            HW2.SquareTask3 s3 = new HW2.SquareTask3(x: 5, y: 3);
            s3.Draw();
            Console.WriteLine();

            Console.WriteLine("\n--- Task4 ---");
            HW2.RectangleTask4 r4 = new HW2.RectangleTask4(x: 5, y: 3);
            HW2.SquareTask4 s4 = new HW2.SquareTask4(x: 5, y: 3);

            r4.DrawAll(r4, s4);
        }

        public static void Hw3()
        {

            Console.WriteLine("\n----- HomeWork 3 -----");
            Console.WriteLine("\n--- Task1 ---");
            HW3.Task1 task1 = new HW3.Task1();
            task1.RandomList();
            task1.OutputList();

            Console.WriteLine("\n--- Task2 ---");
            List<HW3.Person> people = new List<HW3.Person>();

            HW3.Task2 task2 = new HW3.Task2();
            List<string> phones;
            string name;
            byte age = 0, count = 0;
            task2.RandomList();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nAdding new person number {i + 1}");
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Age: ");

                if (!byte.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Incorrect input");
                    break;
                }

                phones = new List<string>();
                Console.Write($"Phone number: ");
                phones.Add(Console.ReadLine());

                people.Add(new HW3.Person() { Name = name, Age = age, PhoneNumbers = phones });
            }

            task2.NewPeople(people);
            task2.OutputList();

            HW3.Task3 task3 = new HW3.Task3();
            Console.Clear();
            List<string> strings = new List<string>();
            byte input = 0;

            while (true)
            {
                Console.WriteLine("\n--- Task 3 ---\nWhat to do?\n");

                Console.WriteLine("[1] Create random list");
                Console.WriteLine("[2] Delete repeats");
                Console.WriteLine("[3] Delete where first 'Z'");
                Console.WriteLine("[4] Sort list (z - a)");
                Console.WriteLine("[5] Display page of the list");
                Console.WriteLine("[6] Display list\n");

                Console.Write("Enter number from 1 to 6 -> ");
                input = Convert.ToByte(Console.ReadLine());

                if (strings.Count == 0 && input != 1)
                {
                    Console.WriteLine("\nError!\nFirst, create a new list\nPress any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine("\nCreated new random string list");
                        strings = task3.RandomListGeneration();
                        break;
                    case 2:
                        Console.WriteLine("\nDeleted Repetitions in the list");
                        strings = task3.DeleteRepeats(strings);
                        break;
                    case 3:
                        Console.WriteLine("\nDeleted rows that begin on Z");
                        strings = task3.DeleteWhereZ(strings);
                        break;
                    case 4:
                        Console.WriteLine("\nSorted list (z - a)");
                        strings = task3.SortList(strings);
                        break;
                    case 5:
                        Console.Write("Enter page of list -> ");
                        byte page = Convert.ToByte(Console.ReadLine());
                        task3.DisplayPage(page, strings);
                        break;
                    case 6:
                        task3.OutputList(strings);
                        break;
                    default:
                        Console.WriteLine("Error!\nEnter number from 1 to 6");
                        break;
                }

                Console.WriteLine("\nPress to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}