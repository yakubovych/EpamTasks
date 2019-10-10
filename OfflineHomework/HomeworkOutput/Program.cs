namespace HomeworkOutput
{
    using System;

    class Program
    {
        public static bool CheckHomework;
        public static bool CheckTasksFirst;
        public static bool CheckTasksSecond;

        static void Main(string[] args)
        {
            while (!CheckTasksFirst)
            {
                Console.WriteLine("-----Offline part tasks-----");
                Console.WriteLine(
                    "Select homework: \n" +
                    "(1) Check first task;\n" +
                    "(2) Check second homework;\n" +
                    "(0)  Exit.\n");
                Console.WriteLine("What action do you choose?");
                string number = Console.ReadLine();
                Console.Clear();
                switch (number)
                {
                    case "1":
                        FirstHomework();
                        break;
                    case "2":
                        SecondHomework();
                        break;
                    case "0":
                        CheckTasksFirst = true;
                        break;
                    default:
                        Console.WriteLine("Input error!");
                        break;
                }
            }
        }

        public static void FirstHomework()
        {
            Console.WriteLine("---First Homework---");
            while (!CheckTasksFirst)
            {
                Console.WriteLine(
                    "Select an action: \n" +
                    "(1)  Check first task;\n" +
                    "(2)  Check second task;\n" +
                    "(3)  Check third task;\n" +
                    "(4)  Check fourth task;\n" +
                    "(5)  Check fifth task;\n" +
                    "(second) Check second homework;\n" +
                    "(0)  Exit.\n");

                Console.WriteLine("What action do you choose?");
                string number = Console.ReadLine();
                Console.Clear();
                switch (number)
                {
                    case "1":
                        FirstTrain.Task1();
                        break;
                    case "2":
                        FirstTrain.Task2();
                        break;
                    case "3":
                        FirstTrain.Task3();
                        break;
                    case "4":
                        FirstTrain.Task4();
                        break;
                    case "5":
                        FirstTrain.Task5();
                        break;
                    case "0":
                        CheckTasksFirst = true;
                        break;
                    case "second":
                        SecondHomework();
                        break;
                    default:
                        Console.WriteLine("Input error!");
                        break;
                }
            }
        }

        public static void SecondHomework()
        {
            Console.WriteLine("---Second Homework---");
            while (!CheckTasksSecond)
            {
                Console.WriteLine(
                    "Select an action: \n" +
                    "(1)  Check first task;\n" +
                    "(2)  Check second task;\n" +
                    "(3)  Check third task;\n" +
                    "(4)  Check fourth task;\n" +
                    "(5)  Check fifth task;\n" +
                    "(first) Check first homework;\n" +
                    "(0)  Exit.\n");

                Console.WriteLine("What action do you choose?");
                string number = Console.ReadLine();
                Console.Clear();
                switch (number)
                {
                    case "1":
                        SecondTrain.Task1();
                        break;
                    case "2":
                        SecondTrain.Task2();
                        break;
                    case "3":
                        SecondTrain.Task3();
                        break;
                    case "4":
                        SecondTrain.Task4();
                        break;
                    case "5":
                        SecondTrain.Task5();
                        break;
                    case "0":
                        CheckTasksSecond = true;
                        break;
                    case "first":
                        FirstHomework();
                        break;
                    default:
                        Console.WriteLine("Input error!");
                        break;
                }
            }
        }
    }
}