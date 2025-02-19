using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> uniquePolicies = new HashSet<string> { "P1001", "P1002", "P1003" };
        SortedSet<string> sortedPolicies = new SortedSet<string>(uniquePolicies);
        
        Console.WriteLine("All Unique Policies: " + string.Join(", ", uniquePolicies));
        Console.WriteLine("Sorted Policies: " + string.Join(", ", sortedPolicies));
    }
}
