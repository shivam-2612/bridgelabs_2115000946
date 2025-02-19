using System;
using System.Collections.Generic;

class Program
{
    static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2) => set1.SetEquals(set2);

    static void Main()
    {
        Console.WriteLine(AreSetsEqual(new HashSet<int> { 1, 2, 3 }, new HashSet<int> { 3, 2, 1 }));
    }
}
