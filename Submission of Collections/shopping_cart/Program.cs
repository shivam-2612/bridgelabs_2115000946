using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedDictionary<string, double> cart = new SortedDictionary<string, double>
        {
            { "Laptop", 800.50 }, { "Phone", 500.75 }, { "Mouse", 25.30 }
        };
        foreach (var item in cart)
            Console.WriteLine($"{item.Key}: ${item.Value}");
    }
}
