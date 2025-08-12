using System;
using System.Collections.Generic;

namespace readaperson
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName ?? string.Empty;
            LastName = lastName ?? string.Empty;
            Age = age;
        }

        public void DisplayInfo()
            => Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");

        public static Person FromConsole()
        {
            string fn, ln;
            int a;

            // First name
            do
            {
                Console.Write("First name: ");
                fn = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(fn));

            // Last name
            do
            {
                Console.Write("Last name: ");
                ln = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(ln));

            // Age
            Console.Write("Age: ");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0)
                Console.Write("Please enter a valid non-negative age: ");

            return new Person(fn, ln, a);
        }
    }

    class Program
    {
        static void Main()
        {
            int count = 0;
            do
            {
                Console.Write("Number of people: ");
            } while (!int.TryParse(Console.ReadLine(), out count) || count <= 0);

            var people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter info for person #{i + 1}:");
                people.Add(Person.FromConsole());
            }

            Console.WriteLine("\nAll people entered:");
            foreach (var p in people)
                p.DisplayInfo();
        }
    }
}   

