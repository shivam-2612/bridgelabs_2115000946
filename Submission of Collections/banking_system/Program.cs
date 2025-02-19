using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, double> accountBalances = new Dictionary<int, double> { { 101, 5000 }, { 102, 3000 } };
        Queue<int> withdrawals = new Queue<int>(new[] { 101, 102 });

        while (withdrawals.Count > 0)
            Console.WriteLine($"Processing withdrawal for account {withdrawals.Dequeue()}");
    }
}
