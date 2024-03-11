using System;

class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }

    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }

    public Student(int i)
    {
        Id = i;
        FirstName = "";
        LastName = "";
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student(1);
        student1.FirstName = "Kayden";
        student1.LastName = "Krumrie";

        Student student2 = new Student(2, "Michael", "Glesmith");

        Console.WriteLine("Student 1:");
        Console.WriteLine($"ID: {student1.Id}");
        Console.WriteLine($"First Name: {student1.FirstName}");
        Console.WriteLine($"Last Name: {student1.LastName}\n");

        Console.WriteLine("Student 2:");
        Console.WriteLine($"ID: {student2.Id}");
        Console.WriteLine($"First Name: {student2.FirstName}");
        Console.WriteLine($"Last Name: {student2.LastName}");
    }
}
