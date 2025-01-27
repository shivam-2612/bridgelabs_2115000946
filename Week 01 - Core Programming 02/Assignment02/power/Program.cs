using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter base number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter power: ");
        int power = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
        Console.WriteLine($"{number} to the power {power} is {result}");
    }
}
