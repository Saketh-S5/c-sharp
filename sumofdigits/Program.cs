using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofdigits
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                int n = Math.Abs(num);
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                Console.WriteLine($"Sum of digits: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

