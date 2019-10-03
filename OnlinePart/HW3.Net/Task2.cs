using System;
using System.Collections.Generic;
using System.Text;

namespace HW3.Net
{
    public class Task2
    {
        List<Person> people;
        Random rnd = new Random();

        public Task2() { }

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
                PhoneNumbers = new List<string> { PhoneNumber(), PhoneNumber() }
            };
        }

        private int RandomNumber()
        {
            return rnd.Next(1, 5);
        }

        private string RandomName()
        {
            string name = string.Empty;
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h" };
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

        public void NewPeople(List<Person> people)
        {
            this.people.AddRange(people);
        }

        public void OutputList()
        {
            foreach (var person in people)
            {
                Console.Write($"Name: {person.Name} \t Age: {person.Age} \t  Number: ");
                foreach (var number in person.PhoneNumbers)
                {
                    Console.Write($"{number}\t");
                }

                Console.WriteLine();
            }
        }
    }
}