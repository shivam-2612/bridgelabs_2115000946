using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<int> set = new SortedSet<int> { 5, 3, 9, 1 };
        Console.WriteLine(string.Join(", ", set));
    }
}
