using System;
using System.Collections.Generic;

class Program
{
    static bool IsSubset(HashSet<int> subset, HashSet<int> superset) => superset.IsSupersetOf(subset);

    static void Main()
    {
        Console.WriteLine(IsSubset(new HashSet<int> { 2, 3 }, new HashSet<int> { 1, 2, 3, 4 }));
    }
}
