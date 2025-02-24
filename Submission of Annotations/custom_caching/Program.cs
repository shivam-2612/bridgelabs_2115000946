using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResult : Attribute { }

class ExpensiveOperations
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();

    [CacheResult]
    public int ComputeSquare(int number)
    {
        string key = $"Square_{number}";
        if (cache.ContainsKey(key))
            return (int)cache[key];

        int result = number * number;
        cache[key] = result;
        return result;
    }
}

class Program
{
    static void Main()
    {
        ExpensiveOperations operations = new ExpensiveOperations();
        Console.WriteLine($"First call: {operations.ComputeSquare(5)}");
        Console.WriteLine($"Second call (cached): {operations.ComputeSquare(5)}");
    }
}
