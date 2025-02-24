using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethod : Attribute
{
    public string Level { get; }

    public ImportantMethod(string level = "HIGH")
    {
        Level = level;
    }
}

class Project
{
    [ImportantMethod("HIGH")]
    public void CriticalFunction()
    {
        Console.WriteLine("Executing critical function.");
    }

    [ImportantMethod("MEDIUM")]
    public void RegularFunction()
    {
        Console.WriteLine("Executing regular function.");
    }
}

class Program
{
    static void Main()
    {
        var methods = typeof(Project).GetMethods();
        foreach (var method in methods)
        {
            var attributes = method.GetCustomAttributes(typeof(ImportantMethod), false);
            foreach (ImportantMethod attr in attributes)
            {
                Console.WriteLine($"Method: {method.Name}, Level: {attr.Level}");
            }
        }
    }
}
