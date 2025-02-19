using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 }, set2 = new HashSet<int> { 3, 4, 5 };
        set1.UnionWith(set2);
        Console.WriteLine("Union: " + string.Join(", ", set1));

        set1 = new HashSet<int> { 1, 2, 3 };
        set1.IntersectWith(set2);
        Console.WriteLine("Intersection: " + string.Join(", ", set1));
    }
}
