namespace HomeworkOutput
{
    using System;
    using Task1 = OfflineHomework.FirstTraining.Task1;
    using Task2 = OfflineHomework.FirstTraining.Task2;
    using Task3 = OfflineHomework.FirstTraining.Task3;
    using Task4 = OfflineHomework.FirstTraining.Task4;
    using Task5 = OfflineHomework.FirstTraining.Task5;

    class Program
    {
        public static bool CheckTasks;

        static void Main(string[] args)
        {
            Console.WriteLine("-----Offline part tasks-----");

            while (!CheckTasks)
            {
                Console.WriteLine("Select an action: \n" +
                    "(1)  Check first task;\n" +
                    "(2)  Check second task;\n" +
                    "(3)  Check third task;\n" +
                    "(4)  Check fourth task;\n" +
                    "(5)  Check fifth task;\n" +
                    "(0)  Exit;\n" +
                    "(clear)  Clear console.\n");

                Console.WriteLine("What action do you choose?");
                string index = Console.ReadLine();

                switch (index)
                {
                    case "1":
                        Console.Clear();
                        Task1();
                        break;
                    case "2":
                        Console.Clear();
                        Task2();
                        break;
                    case "3":
                        Console.Clear();
                        Task3();
                        break;
                    case "4":
                        Console.Clear();
                        Task4();
                        break;
                    case "5":
                        Console.Clear();
                        Task5();
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

        public static bool Task1()
        {
            Console.WriteLine("\n----- HomeWork 1 -----");
            Console.WriteLine("\n--- Task1 ---");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (String.IsNullOrEmpty(name) && name.Length > 1)
            {
                Console.WriteLine("Incorrect input!");
            }

            if (String.IsNullOrEmpty(surname) && surname.Length > 1)
            {
                Console.WriteLine("Incorrect input!");
            }

            if (age <= 1 || age >= 100)
            {
                Console.WriteLine("Incorrect input");
            }

            Task1.Person person = new Task1.Person(name, surname, age);
            Console.Write("Enter number to compare: ");
            int n = Convert.ToInt32(Console.ReadLine());
            person.CompareAgeWithInput(n);
            Console.WriteLine("----------------------------");
            return true;
        }

        public static void Task2()
        {
            Console.WriteLine("--- Task2 ---");
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter X coordinate of rectangle: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y coordinate of rectangle: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Task2.Rectangle rectangle = new Task2.Rectangle { Width = width, Height = height, X = x, Y = y };
            Console.WriteLine($"Perimeter of rectangle = {rectangle.Perimeter()}");
            Console.WriteLine("----------------------------");
        }

        public static void Task3()
        {
            Console.WriteLine("--- Task3 ---");
            Console.Write("Input number of month: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 12)
            {
                Console.WriteLine("Incorrect input!");
            }
            Console.WriteLine($"{(Task3.Month)n}");
            Console.WriteLine("----------------------------");
        }

        public static void Task4()
        {
            Console.WriteLine("--- Task4 ---");
            foreach (var i in Enum.GetValues(typeof(Task4.Colors)))
            {
                Console.WriteLine($"{i} = {(int)i}");
            }

            Console.WriteLine("----------------------------");
        }

        public static void Task5()
        {
            Console.WriteLine("--- Task5 ---");
            foreach (var i in Enum.GetValues(typeof(Task5.LongRange)))
            {
                Console.WriteLine($"{i} = {(long)i}");
            }
        }
    }
}
