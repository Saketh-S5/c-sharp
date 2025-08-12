namespace Greet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            String name = Console.ReadLine();
            PP p = new PP(name);
            p.greet();

        }
    }
}