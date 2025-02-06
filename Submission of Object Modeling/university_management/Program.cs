using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; set; }
    public Professor AssignedProfessor { get; private set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }

    public void AssignProfessor(Professor professor)
    {
        AssignedProfessor = professor;
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
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

    public void EnrollCourse(Course course)
    {
        course.EnrollStudent(this);
    }
}

class Professor
{
    public string Name { get; set; }

    public Professor(string name)
    {
        Name = name;
    }
}

class University
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public University(string name)
    {
        Name = name;
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}

class Program
{
    static void Main()
    {
        University university = new University("Harvard");
        Student student = new Student("Alice");
        Professor professor = new Professor("Dr. Smith");
        Course course = new Course("Computer Science");
        course.AssignProfessor(professor);
        student.EnrollCourse(course);
        university.AddCourse(course);
    }
}
