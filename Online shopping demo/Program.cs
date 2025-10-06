using System;

namespace Online_shopping_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base product example
            Product chair = new Product("Office Chair", 3500);
            Console.WriteLine("=== General Product ===");
            chair.DisplayInfo();

            Console.WriteLine();

            // Electronic product example
            ElectronicProduct laptop = new ElectronicProduct("Laptop", 55000, "Dell", 24);
            Console.WriteLine("=== Electronic Product ===");
            laptop.DisplayInfo();

            Console.WriteLine();

            // Smartphone example
            Smartphone phone = new Smartphone("iPhone 15", 79999, "Apple", 12, "iOS", 256);
            Console.WriteLine("=== Smartphone ===");
            phone.DisplayInfo();
        }
    }
}