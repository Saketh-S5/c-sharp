using System;

namespace DataEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();

            Person1.Name = "saketh";
            Person1.Age = 20;
            Console.WriteLine($"Name: {Person1.Name} ; Age: {Person1.Age}");
        }
    }
}