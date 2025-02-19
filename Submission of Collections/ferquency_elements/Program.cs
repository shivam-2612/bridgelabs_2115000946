using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> GetFrequency(List<string> list)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (var item in list)
            frequency[item] = frequency.ContainsKey(item) ? frequency[item] + 1 : 1;
        return frequency;
    }

    static void Main()
    {
        List<string> words = new List<string> { "apple", "banana", "apple", "orange" };
        var result = GetFrequency(words);
        foreach (var kvp in result)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
