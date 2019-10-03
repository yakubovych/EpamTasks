namespace OfflineHomework.FirstTraining.Task1
{
    using System;

    public struct Person
    {
        private string name;
        private string surname;
        private int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void CompareAgeWithInput(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Input Error!");
            }

            if (this.age > n)
            {
                Console.WriteLine($"{this.name} {this.surname} older than {n}");
            }
            else
            {
                Console.WriteLine($"{this.name} {this.surname} younger than {n}");
            }
        }
    }
}
