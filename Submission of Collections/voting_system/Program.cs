using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int> { { "Alice", 3 }, { "Bob", 5 }, { "Charlie", 2 } };
        foreach (var kvp in new SortedDictionary<string, int>(votes))
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
