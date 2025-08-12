using System;

namespace Sq.OfANumber
{
    public class Square
    {
        // Returns the square of the given number
        public static int Calculate(int number)
        {
            return number * number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its square:");
            int inputNumber;
           
            int result = Square.Calculate(inputNumber);
            Console.WriteLine($"The square of {inputNumber} is {result}.");
        }
    }
}
