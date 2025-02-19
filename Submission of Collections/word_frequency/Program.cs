using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static Dictionary<string, int> CountWordFrequency(string text)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (var word in text.ToLower().Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
            frequency[word] = frequency.ContainsKey(word) ? frequency[word] + 1 : 1;
        return frequency;
    }

    static void Main()
    {
        string text = "Hello world, hello Java!";
        var result = CountWordFrequency(text);
        foreach (var kvp in result)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
