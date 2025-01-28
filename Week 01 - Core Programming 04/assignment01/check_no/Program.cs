using System;

class Program
{
    static int CheckNumber(int num)
    {
        return num > 0 ? 1 : num < 0 ? -1 : 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"The number is: {CheckNumber(number)}");
    }
}
