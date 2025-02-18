using System;
using System.Collections.Generic;

abstract class CourseType { }
class ExamCourse : CourseType { }
class AssignmentCourse : CourseType { }

class Course<T> where T : CourseType
{
    public string CourseName { get; set; }
}

class Program
{
    static void Main()
    {
        List<Course<ExamCourse>> examCourses = new List<Course<ExamCourse>>
        {
            new Course<ExamCourse> { CourseName = "Mathematics" }
        };

        foreach (var course in examCourses)
            Console.WriteLine($"Exam Course: {course.CourseName}");
    }
}
