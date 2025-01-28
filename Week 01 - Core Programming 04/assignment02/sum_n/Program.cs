using System;
class Program
{
static int SumUsingRecursion(int n)
{
if (n == 1) return 1;
return n + SumUsingRecursion(n - 1);
}
static int SumUsingFormula(int n)
{
return n * (n + 1) / 2;
}
static void Main(string[] args)
{
Console.WriteLine("Enter a natural number:");
int n = int.Parse(Console.ReadLine());
if (n <= 0)
{
Console.WriteLine("Invalid input. Exiting...");
return;
}
int sumRecursion = SumUsingRecursion(n);
int sumFormula = SumUsingFormula(n);
Console.WriteLine($"Sum using recursion: {sumRecursion}");
Console.WriteLine($"Sum using formula: {sumFormula}");
Console.WriteLine($"Results match: {sumRecursion == sumFormula}");
}
}
