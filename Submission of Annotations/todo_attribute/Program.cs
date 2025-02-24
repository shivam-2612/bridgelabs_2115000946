using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class Todo : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public Todo(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Development
{
    [Todo("Implement login", "John")]
    public void LoginFeature() { }

    [Todo("Fix payment bug", "Alice", "HIGH")]
    public void PaymentFeature() { }
}

class Program
{
    static void Main()
    {
        var methods = typeof(Development).GetMethods();
        foreach (var method in methods)
        {
            var attributes = method.GetCustomAttributes(typeof(Todo), false);
            foreach (Todo attr in attributes)
            {
                Console.WriteLine($"Task: {attr.Task}, Assigned To: {attr.AssignedTo}, Priority: {attr.Priority}");
            }
        }
    }
}
