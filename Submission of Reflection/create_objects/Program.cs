using System;

class Student
{
    public string Name { get; set; }
    public Student() => Name = "John Doe";
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);
        object student = Activator.CreateInstance(type);
        Console.WriteLine("Student Name: " + ((Student)student).Name);
    }
}
