using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(int bookId, string title, string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"Book ID: {BookId}, Title: {Title}, Author: {Author}";
    }
}

class LibraryManagement<T> where T : Book
{
    private List<T> books = new List<T>();

    // 1️⃣ Add new book
    public void AddBook(T book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully!\n");
    }

    // 2️⃣ Display all books
    public void DisplayAll()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in library.\n");
            return;
        }

        Console.WriteLine("\n--- Books in Library ---");
        foreach (var b in books)
            Console.WriteLine(b);
        Console.WriteLine();
    }

    // 3️⃣ Search a book by ID
    public void SearchById(int id)
    {
        var book = books.FirstOrDefault(b => b.BookId == id);
        if (book != null)
            Console.WriteLine($"Book Found: {book}\n");
        else
            Console.WriteLine("Book not found.\n");
    }

    // 4️⃣ Remove a book by ID
    public void RemoveById(int id)
    {
        var book = books.FirstOrDefault(b => b.BookId == id);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book removed successfully!\n");
        }
        else
            Console.WriteLine("Book not found.\n");
    }

    // 5️⃣ Count how many books available
    public void CountBooks()
    {
        Console.WriteLine($"Total number of books in library: {books.Count}\n");
    }
}

class Program
{
    static void Main()
    {
        LibraryManagement<Book> library = new LibraryManagement<Book>();
        while (true)
        {
            Console.WriteLine("=== Library Book Management System ===");
            Console.WriteLine("1. Add New Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Search Book by ID");
            Console.WriteLine("4. Remove Book by ID");
            Console.WriteLine("5. Check Total Books");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    library.AddBook(new Book(id, title, author));
                    break;

                case 2:
                    library.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter Book ID to search: ");
                    int sid = Convert.ToInt32(Console.ReadLine());
                    library.SearchById(sid);
                    break;

                case 4:
                    Console.Write("Enter Book ID to remove: ");
                    int rid = Convert.ToInt32(Console.ReadLine());
                    library.RemoveById(rid);
                    break;

                case 5:
                    library.CountBooks();
                    break;

                case 6:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }
        }
    }
}
