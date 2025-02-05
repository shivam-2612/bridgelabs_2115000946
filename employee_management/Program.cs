using System;

class Employee
{
    private static int totalEmployees = 0;
    private static string CompanyName = "Tech Corp";
    private readonly int Id;
    private string Name, Designation;

    public Employee(int id, string name, string designation)
    {
        this.Id = id;
        this.Name = name;
        this.Designation = designation;
        totalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees: {totalEmployees}");
    }

    public void DisplayEmployeeDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine($"Employee ID: {Id}, Name: {Name}, Designation: {Designation}, Company: {CompanyName}");
        }
    }
}
