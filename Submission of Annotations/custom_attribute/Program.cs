using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfo : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfo(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("High", "Alice")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

class Program
{
    static void Main()
    {
        TaskManager manager = new TaskManager();
        MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
        var attributes = method.GetCustomAttributes(typeof(TaskInfo), false);
        foreach (TaskInfo attr in attributes)
        {
            Console.WriteLine($"Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
        }
    }
}
