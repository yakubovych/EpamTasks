namespace HW3.Net
{
    using System;
    using System.Collections.Generic;

    public class Task1
    {
        List<Person> people;
        Random rnd = new Random();

        public Task1() { }

        public void RandomList()
        {
            people = new List<Person>()
            {
                RandomPerson(),
                RandomPerson(),
                RandomPerson(),
                RandomPerson(),
                RandomPerson(),
                RandomPerson()
            };
        }

        private Person RandomPerson()
        {
            return new Person
            {
                Name = RandomName(),
                Age = RandomNumber(),
                PhoneNumbers = new List<string> { PhoneNumber(), PhoneNumber() },
            };
        }

        private int RandomNumber()
        {
            return rnd.Next(12, 100);
        }

        private string RandomName()
        {
            string name = "";
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h"};
            for (int i = 0; i < 6; i++)
            {
                name += letters[rnd.Next(letters.Length)];
            }

            return name;
        }

        private string PhoneNumber()
        {
            string number = "+38 (0";

            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    number += ") ";
                }
                else
                {
                    number += rnd.Next(0, 9).ToString();
                }
            }

            return number;
        }

        public void OutputList()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name} \t\t Age: {person.Age}");
            }
        }
    }
}
