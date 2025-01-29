using System;

class Program
{
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;

    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Choose operation (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = op switch
        {
            '+' => Add(num1, num2),
            '-' => Subtract(num1, num2),
            '*' => Multiply(num1, num2),
            '/' => Divide(num1, num2),
            _ => double.NaN
        };

        Console.WriteLine("Result: " + result);
    }
}
