using System;
using System.Collections.Generic;

class Document
{
    public string DocName { get; set; }

    public Document(string name)
    {
        DocName = name;
    }

    public override string ToString()
    {
        return $"Document: {DocName}";
    }
}

class PrinterQueue<T> where T : Document
{
    private Queue<T> printQueue = new Queue<T>();

    // 1️⃣ Add document to print queue
    public void AddDocument(T doc)
    {
        printQueue.Enqueue(doc);
        Console.WriteLine($"'{doc.DocName}' added to the print queue.\n");
    }

    // 2️⃣ Print next document (FIFO)
    public void PrintNext()
    {
        if (printQueue.Count == 0)
        {
            Console.WriteLine("No documents in queue.\n");
            return;
        }

        var doc = printQueue.Dequeue();
        Console.WriteLine($"Printing: {doc.DocName}\n");
    }

    // 3️⃣ Display all documents waiting in the queue
    public void DisplayAll()
    {
        if (printQueue.Count == 0)
        {
            Console.WriteLine("No documents waiting to print.\n");
            return;
        }

        Console.WriteLine("--- Documents in Queue ---");
        foreach (var doc in printQueue)
            Console.WriteLine(doc);
        Console.WriteLine();
    }

    // 4️⃣ Check total documents pending
    public void CountDocuments()
    {
        Console.WriteLine($"Total documents in queue: {printQueue.Count}\n");
    }
}

class Program
{
    static void Main()
    {
        PrinterQueue<Document> printer = new PrinterQueue<Document>();

        while (true)
        {
            Console.WriteLine("=== Real-Time Printer Queue System ===");
            Console.WriteLine("1. Add Document");
            Console.WriteLine("2. Print Next Document");
            Console.WriteLine("3. Display All Documents");
            Console.WriteLine("4. Check Pending Document Count");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter document name: ");
                    string name = Console.ReadLine();
                    printer.AddDocument(new Document(name));
                    break;

                case 2:
                    printer.PrintNext();
                    break;

                case 3:
                    printer.DisplayAll();
                    break;

                case 4:
                    printer.CountDocuments();
                    break;

                case 5:
                    Console.WriteLine("Exiting Printer System...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Try again.\n");
                    break;
            }
        }
    }
}