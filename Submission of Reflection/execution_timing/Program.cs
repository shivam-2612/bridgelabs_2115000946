using System;
using System.Diagnostics;
using System.Reflection;

class TaskClass
{
    public void PerformTask()
    {
        System.Threading.Thread.Sleep(1000);
    }
}

class Program
{
    static void Main()
    {
        TaskClass task = new TaskClass();
        Type type = typeof(TaskClass);
        MethodInfo method = type.GetMethod("PerformTask");

        Stopwatch stopwatch = Stopwatch.StartNew();
        method.Invoke(task, null);
        stopwatch.Stop();

        Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
    }
}
