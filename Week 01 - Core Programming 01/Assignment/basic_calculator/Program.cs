using System;

class Program {
    static void Main() {
        Console.Write("Enter first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Addition: {number1 + number2:F2}, Subtraction: {number1 - number2:F2}, Multiplication: {number1 * number2:F2}, Division: {(number2 != 0 ? number1 / number2 : double.NaN):F2}");
    }
}
