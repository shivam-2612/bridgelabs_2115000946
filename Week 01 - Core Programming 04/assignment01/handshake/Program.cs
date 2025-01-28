using System;

class Program
{
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of students:");
        int students = int.Parse(Console.ReadLine());
        Console.WriteLine($"Maximum number of handshakes: {CalculateHandshakes(students)}");
    }
}
