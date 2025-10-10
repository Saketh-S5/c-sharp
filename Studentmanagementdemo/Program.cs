using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public Student(int id, string name, double marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Marks: {Marks}";
    }
}

class StudentManagement<T> where T : Student
{
    private List<T> students = new List<T>();

    // 1. Add student
    public void AddStudent(T student)
    {
        students.Add(student);
        Console.WriteLine("Student added successfully!\n");
    }

    // 2. Display all students
    public void DisplayAll()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students to display.\n");
            return;
        }

        Console.WriteLine("\n--- Student List ---");
        foreach (var s in students)
            Console.WriteLine(s);
        Console.WriteLine();
    }

    // 3. Search student by ID
    public void SearchById(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
            Console.WriteLine($"Found: {student}\n");
        else
            Console.WriteLine("Student not found.\n");
    }

    // 4. Remove student by ID
    public void RemoveById(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student removed successfully!\n");
        }
        else
            Console.WriteLine("Student not found.\n");
    }

    // 5. Display topper
    public void DisplayTopper()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.\n");
            return;
        }

        var topper = students.OrderByDescending(s => s.Marks).First();
        Console.WriteLine($"Topper of the class:\n{topper}\n");
    }
}

class Program
{
    static void Main()
    {
        StudentManagement<Student> sm = new StudentManagement<Student>();
        while (true)
        {
            Console.WriteLine("=== Student Management System ===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student by ID");
            Console.WriteLine("4. Remove Student by ID");
            Console.WriteLine("5. Display Topper");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Marks: ");
                    double marks = Convert.ToDouble(Console.ReadLine());
                    sm.AddStudent(new Student(id, name, marks));
                    break;

                case 2:
                    sm.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter ID to search: ");
                    int sid = Convert.ToInt32(Console.ReadLine());
                    sm.SearchById(sid);
                    break;

                case 4:
                    Console.Write("Enter ID to remove: ");
                    int rid = Convert.ToInt32(Console.ReadLine());
                    sm.RemoveById(rid);
                    break;

                case 5:
                    sm.DisplayTopper();
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