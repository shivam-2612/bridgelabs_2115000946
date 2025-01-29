using System;

class Program
{
    static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
    static int LCM(int a, int b) => (a * b) / GCD(a, b);

    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: " + GCD(a, b));
        Console.WriteLine("LCM: " + LCM(a, b));
    }
}
