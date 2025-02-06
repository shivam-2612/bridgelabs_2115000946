using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }

    public void EnrollStudent(Student student)
    {
        Students.Add(student);
        student.Courses.Add(this);
    }
}

class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void ViewCourses()
    {
        foreach (var course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }
}

class School
{
    public string Name { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public School(string name)
    {
        Name = name;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}

class Program
{
    static void Main()
    {
        School school = new School("Greenwood High");
        Student student = new Student("John");
        Course course = new Course("Math");
        course.EnrollStudent(student);
        school.AddStudent(student);
        student.ViewCourses();
    }
}
