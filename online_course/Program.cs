class Course
{
    public string CourseName { get; }
    public int Duration { get; }
    public double Fee { get; }
    private static string instituteName = "Default Institute";

    public Course(string courseName, int duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} months, Fee: {Fee}");
    }

    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}
