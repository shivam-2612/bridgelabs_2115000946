using System;

class Program
{
    static double ToCelsius(double f) => (f - 32) * 5 / 9;
    static double ToFahrenheit(double c) => (c * 9 / 5) + 32;

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F): ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.WriteLine(choice == 'C' ? "Celsius: " + ToCelsius(temp) : "Fahrenheit: " + ToFahrenheit(temp));
    }
}
