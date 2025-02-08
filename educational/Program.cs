using System;

class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }
    public virtual void DisplayInfo() => Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
}

class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }
    public override void DisplayInfo() => Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {IsRecorded}");
}

class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public int Discount { get; set; }
    public override void DisplayInfo() => Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {IsRecorded}, Fee: {Fee}, Discount: {Discount}%");
}

class Program
{
    static void Main()
    {
        PaidOnlineCourse course = new PaidOnlineCourse { CourseName = "Advanced C#", Duration = 6, Platform = "Udemy", IsRecorded = true, Fee = 299.99, Discount = 20 };
        course.DisplayInfo();
    }
}
