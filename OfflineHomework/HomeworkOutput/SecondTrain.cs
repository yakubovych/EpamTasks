namespace HomeworkOutput
{
    using System;
    using Task11 = SecondTraining.SecondTraining.Task1;
    using Task22 = SecondTraining.SecondTraining.Task2;
    using Task44 = SecondTraining.SecondTraining.Task4;
    using Task55 = SecondTraining.SecondTraining.Task5;

    class SecondTrain 
    {
        public static void Task1()
        {
            Console.WriteLine("\n----- HomeWork 1 -----");
            Console.WriteLine("\n--- Task1 ---");
            try
            {
                Task11.StackException.RecursiveMethod();
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine($"StackOverflowException: {e.Message}");
            }

            Console.WriteLine("----------------------------");
        }

        public static void Task2()
        {
            Console.WriteLine("--- Task2 ---");
            try
            {
                int[] array = { 5, 10, 4, 1 };
                Task22.RangeException.ArrError(array);
            }
            catch (Exception e)
            {
                Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
            }

            Console.WriteLine("----------------------------");
        }

        public static void Task3()
        {
            Console.WriteLine("--- Task3 ---");
            Console.WriteLine("Generated exceptions logged in event viewer.");
            Console.WriteLine("----------------------------");
        }

        public static void Task4()
        {
            Console.WriteLine("--- Task4 ---");
            try
            {
                int[] array = { 5, 10, 4, 1 };
                Task44.StackOverflowAndRangeExceptions.ArrError(array);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Task44.StackOverflowAndRangeExceptions.RecursiveMethod();
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("StackOverflowException: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----------------------------");
        }

        public static void Task5()
        {
            Task55.MathExceptions.DoSomeMath(-2, -2);
            Task55.MathExceptions.DoSomeMath(2, 2);
            Console.WriteLine("--- Task5 ---");
        }
    }
}
