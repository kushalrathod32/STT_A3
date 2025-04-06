using System;

public class Student
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    // Main constructor
    public Student(string name, int id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    // Overloaded constructor (just name)
    public Student(string name)
    {
        Name = name;
        ID = 0;
        Marks = 0;
    }

    // Copy constructor
    public Student(Student other)
    {
        Name = other.Name;
        ID = other.ID;
        Marks = other.Marks;
    }

    // Method to calculate grade
    public string GetGrade()
    {
        if (Marks >= 90)
            return "A";
        else if (Marks >= 75)
            return "B";
        else if (Marks >= 60)
            return "C";
        else if (Marks >= 45)
            return "D";
        else
            return "F";
    }

    public static void Main()
    {
        // Original object
        Student student1 = new Student("Kushal", 22110128, 100);
        Console.WriteLine("Original Student:");
        Console.WriteLine($"Name: {student1.Name}, ID: {student1.ID}, Marks: {student1.Marks}, Grade: {student1.GetGrade()}");

        // Using overloaded constructor
        Student student2 = new Student("Digvijay");
        Console.WriteLine("\nStudent Created with Overloaded Constructor:");
        Console.WriteLine($"Name: {student2.Name}, ID: {student2.ID}, Marks: {student2.Marks}, Grade: {student2.GetGrade()}");

        // Using copy constructor
        Student student3 = new Student(student1);
        Console.WriteLine("\nCopied Student:");
        Console.WriteLine($"Name: {student3.Name}, ID: {student3.ID}, Marks: {student3.Marks}, Grade: {student3.GetGrade()}");
    }
}

public class StudentIITGN : Student
{
    // New Property
    public string Hostel_Name_IITGN { get; set; }

    // Constructor for derived class
    public StudentIITGN(string name, int id, double marks, string hostelName)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostelName;
    }

    //Main method to create and display IITGN student
    //public new static void Main()
    //{
    //    StudentIITGN iitgnStudent = new StudentIITGN("Jovit", 22110110 , 85, "Hostel-G");
    //    Console.WriteLine($"Name: {iitgnStudent.Name}");
    //    Console.WriteLine($"ID: {iitgnStudent.ID}");
    //    Console.WriteLine($"Marks: {iitgnStudent.Marks}");
    //    Console.WriteLine($"Grade: {iitgnStudent.GetGrade()}");
    //    Console.WriteLine($"Hostel: {iitgnStudent.Hostel_Name_IITGN}");
    //}
}