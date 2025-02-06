using System;
using System.Collections.Generic;

class Faculty
{
    public string Name { get; set; }

    public Faculty(string name)
    {
        Name = name;
    }
}

class Department
{
    public string Name { get; set; }

    public Department(string name)
    {
        Name = name;
    }
}

class University
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; } = new List<Department>();
    public List<Faculty> Faculties { get; set; } = new List<Faculty>();

    public University(string name)
    {
        Name = name;
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }
}

class Program
{
    static void Main()
    {
        University uni = new University("Oxford");
        Faculty faculty = new Faculty("Dr. Smith");
        Department dept = new Department("Physics");
        uni.AddDepartment(dept);
        uni.AddFaculty(faculty);
    }
}
