using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> input)
    {
        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();
        foreach (var kvp in input)
        {
            if (!inverted.ContainsKey(kvp.Value))
                inverted[kvp.Value] = new List<string>();
            inverted[kvp.Value].Add(kvp.Key);
        }
        return inverted;
    }

    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 1 } };
        var result = InvertMap(input);
        foreach (var kvp in result)
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
    }
}
