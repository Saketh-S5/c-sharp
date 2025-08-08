using System;

namespace EvenoddApp
{
    public class Evenodd
    {
        public static void ReadNumber(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Please enter a non-negative integer.");
                return;
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
        