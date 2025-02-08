using System;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }
    public virtual void DisplayDetails() => Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
}

class Manager : Employee
{
    public int TeamSize { get; set; }
    public override void DisplayDetails() => Console.WriteLine($"Manager: {Name}, ID: {Id}, Salary: {Salary}, Team Size: {TeamSize}");
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public override void DisplayDetails() => Console.WriteLine($"Developer: {Name}, ID: {Id}, Salary: {Salary}, Language: {ProgrammingLanguage}");
}

class Intern : Employee
{
    public string InternshipDuration { get; set; }
    public override void DisplayDetails() => Console.WriteLine($"Intern: {Name}, ID: {Id}, Salary: {Salary}, Duration: {InternshipDuration}");
}

class Program
{
    static void Main()
    {
        Employee manager = new Manager { Name = "Alice", Id = 1, Salary = 90000, TeamSize = 10 };
        Employee developer = new Developer { Name = "Bob", Id = 2, Salary = 70000, ProgrammingLanguage = "C#" };
        Employee intern = new Intern { Name = "Charlie", Id = 3, Salary = 30000, InternshipDuration = "6 months" };

        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}
