namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Game of thrones", "G.R.R Martin");
            b.DisplayDetails();
            Book e = new EBook("The lord of rings", "J.R.R Tolkien",900, "EPUB");
            e.DisplayDetails();
        }
    }
}