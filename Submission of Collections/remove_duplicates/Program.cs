﻿using System;
using System.Collections.Generic;

class Program
{
    static List<int> RemoveDuplicates(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (var num in list)
            if (seen.Add(num)) result.Add(num);
        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };
        Console.WriteLine(string.Join(", ", RemoveDuplicates(numbers)));
    }
}
