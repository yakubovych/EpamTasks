namespace SecondTraining.SecondTraining.Task5
{
    using System;

    public class MathExceptions
    {
        public static void DoSomeMath(int a, int b)
        {
            try
            {
                if (a < 0)
                {
                    throw new ArgumentException("Parameter should be greater than 0", "a");
                }
                if (b > 0)
                {
                    throw new ArgumentException("Parameter should be less than 0", "b");
                }
            }
            catch (ArgumentException e)
            when (e.ParamName == "a")
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            when (e.ParamName == "b")
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
