using System;

class Program
{
    static int[] DivideChocolates(int chocolates, int children)
    {
        return new int[] { chocolates / children, chocolates % children };
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of chocolates and children:");
        int chocolates = int.Parse(Console.ReadLine());
        int children = int.Parse(Console.ReadLine());
        int[] result = DivideChocolates(chocolates, children);
        Console.WriteLine($"Each child gets: {result[0]}, Remaining chocolates: {result[1]}");
    }
}
