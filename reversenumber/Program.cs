using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer to reverse: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int reversed = ReverseNumber(number);
                Console.WriteLine($"Reversed number: {reversed}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        static int ReverseNumber(int num)
        {
            int reversed = 0;
            int n = Math.Abs(num);
            while (n > 0)
            {
                int digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }
            return num < 0 ? -reversed : reversed;
        }
    }
}


