using System;

class Program
{
    static void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.Write($"{a} {b} ");
        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }

    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = int.Parse(Console.ReadLine());
        Fibonacci(n);
    }
}
