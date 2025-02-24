using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReport : Attribute
{
    public string Description { get; }

    public BugReport(string description)
    {
        Description = description;
    }
}

class Software
{
    [BugReport("NullReferenceException when input is null")]
    [BugReport("Incorrect output for negative values")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

class Program
{
    static void Main()
    {
        Software software = new Software();
        MethodInfo method = typeof(Software).GetMethod("ProcessData");
        var bugReports = method.GetCustomAttributes(typeof(BugReport), false);

        foreach (BugReport bug in bugReports)
        {
            Console.WriteLine($"Bug Description: {bug.Description}");
        }
    }
}
