using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void DisplayRole() => Console.WriteLine($"Name: {Name}, Age: {Age}");
}

class Teacher : Person
{
    public string Subject { get; set; }
    public override void DisplayRole() => Console.WriteLine($"Teacher - Name: {Name}, Age: {Age}, Subject: {Subject}");
}

class Student : Person
{
    public string Grade { get; set; }
    public override void DisplayRole() => Console.WriteLine($"Student - Name: {Name}, Age: {Age}, Grade: {Grade}");
}

class Staff : Person
{
    public string Department { get; set; }
    public override void DisplayRole() => Console.WriteLine($"Staff - Name: {Name}, Age: {Age}, Department: {Department}");
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher { Name = "Alice", Age = 30, Subject = "Mathematics" };
        teacher.DisplayRole();
    }
}
