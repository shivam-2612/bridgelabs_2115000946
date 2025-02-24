using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTime : Attribute { }

class Performance
{
    [LogExecutionTime]
    public void FastTask()
    {
        System.Threading.Thread.Sleep(500);
    }

    [LogExecutionTime]
    public void SlowTask()
    {
        System.Threading.Thread.Sleep(1500);
    }
}

class Program
{
    static void Main()
    {
        var methods = typeof(Performance).GetMethods();
        var instance = new Performance();

        foreach (var method in methods)
        {
            if (method.GetCustomAttribute(typeof(LogExecutionTime)) != null)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(instance, null);
                stopwatch.Stop();
                Console.WriteLine($"{method.Name} took {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
