using System;

class Student
{
    private static int totalStudents = 0;
    private static string UniversityName = "Global University";
    private readonly int RollNumber;
    private string Name;
    private double Grade;

    public Student(int rollNumber, string name, double grade)
    {
        this.RollNumber = rollNumber;
        this.Name = name;
        this.Grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"Total Students: {totalStudents}");
    }

    public void DisplayStudentDetails()
    {
        if (this is Student)
        {
            Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, Grade: {Grade}, University: {UniversityName}");
        }
    }
}
