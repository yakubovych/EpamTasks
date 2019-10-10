namespace SecondTraining.SecondTraining.Task4
{
    public class StackOverflowAndRangeExceptions
    {
        public static int RecursiveMethod()
        {
            return RecursiveMethod();
        }

        public static int ArrError(int[] arr)
        {
            return arr[5];
        }
    }
}
