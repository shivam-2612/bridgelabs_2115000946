using System;

class Program
{
    static int[] FindSmallestAndLargest(int a, int b, int c)
    {
        int smallest = Math.Min(a, Math.Min(b, c));
        int largest = Math.Max(a, Math.Max(b, c));
        return new int[] { smallest, largest };
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int[] result = FindSmallestAndLargest(a, b, c);
        Console.WriteLine($"Smallest: {result[0]}, Largest: {result[1]}");
    }
}
