namespace OfflineHomework.FirstTraining.Task4
{
    using System;

    public enum Colors { Red = 4, Blue = 10, Yellow = 5, Black = 7 };

    public static class Extension
    {
        public static void SortEnum()
        {
            foreach (var i in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{i} = {(int)i}");
            }
        }
    }
}
