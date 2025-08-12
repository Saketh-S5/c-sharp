using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace possitivenegetiveorzero
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number > 0)
                    Console.WriteLine($"{number} is positive.");
                else if (number < 0)
                    Console.WriteLine($"{number} is negative.");
                else
                    Console.WriteLine("The number is zero.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
            }
        }
    }
}
