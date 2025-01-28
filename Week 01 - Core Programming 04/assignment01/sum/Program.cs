using System;

class Program
{
    static int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum of first {n} natural numbers is: {SumOfNaturalNumbers(n)}");
    }
}
