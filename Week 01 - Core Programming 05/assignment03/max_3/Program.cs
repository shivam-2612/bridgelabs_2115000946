using System;

class Program
{
    static int MaxOfThree(int a, int b, int c) => (a > b && a > c) ? a : (b > c ? b : c);

    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Maximum Number: " + MaxOfThree(a, b, c));
    }
}
