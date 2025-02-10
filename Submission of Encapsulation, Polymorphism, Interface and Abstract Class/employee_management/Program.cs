using System;
using System.Collections.Generic;

interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    public int EmployeeId { get => employeeId; }
    public string Name { get => name; set => name = value; }
    public double BaseSalary { get => baseSalary; set => baseSalary = value > 0 ? value : 0; }

    public Employee(int id, string name, double salary)
    {
        this.employeeId = id;
        this.Name = name;
        this.BaseSalary = salary;
    }

    public abstract double CalculateSalary();
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary():C}");
    }
}

class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }

    public override double CalculateSalary() => BaseSalary;

    public void AssignDepartment(string dept) => department = dept;
    public string GetDepartmentDetails() => $"Department: {department}";
}

class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int hoursWorked;
    private double hourlyRate;

    public PartTimeEmployee(int id, string name, int hours, double rate) : base(id, name, 0)
    {
        this.hoursWorked = hours;
        this.hourlyRate = rate;
    }

    public override double CalculateSalary() => hoursWorked * hourlyRate;

    public void AssignDepartment(string dept) => department = dept;
    public string GetDepartmentDetails() => $"Department: {department}";
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Shivam", 50000),
            new PartTimeEmployee(2, "Vanshaj", 20, 25)
        };

        foreach (var emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
