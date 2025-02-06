using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
}

class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();

    public Department(string name)
    {
        Name = name;
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}

class Company
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; } = new List<Department>();

    public Company(string name)
    {
        Name = name;
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }
}

class Program
{
    static void Main()
    {
        Company company = new Company("TechCorp");
        Department dept = new Department("IT");
        dept.AddEmployee(new Employee("Alice"));
        company.AddDepartment(dept);
    }
}
