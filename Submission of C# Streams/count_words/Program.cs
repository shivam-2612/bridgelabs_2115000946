using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program {
    static void Main() {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        foreach (var word in File.ReadAllText("text.txt").Split(' ', '.', ',', '\n', '\r')) {
            if (string.IsNullOrWhiteSpace(word)) continue;
            string w = word.ToLower();
            if (!freq.ContainsKey(w)) freq[w] = 0;
            freq[w]++;
        }
        foreach (var kv in freq.OrderByDescending(k => k.Value).Take(5)) Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}
