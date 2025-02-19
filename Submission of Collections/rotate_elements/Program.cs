using System;
using System.Collections.Generic;

class Program
{
    static List<int> RotateList(List<int> list, int k)
    {
        int n = list.Count;
        k %= n;
        List<int> rotated = new List<int>(list.GetRange(k, n - k));
        rotated.AddRange(list.GetRange(0, k));
        return rotated;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        List<int> rotated = RotateList(numbers, 2);
        Console.WriteLine(string.Join(", ", rotated));
    }
}
