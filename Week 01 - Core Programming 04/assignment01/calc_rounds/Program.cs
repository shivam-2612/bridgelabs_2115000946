using System;

class Program
{
    static int CalculateRounds(double side1, double side2, double side3, double distance)
    {
        double perimeter = side1 + side2 + side3;
        return (int)Math.Ceiling(distance / perimeter);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the three sides of the triangle:");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Rounds needed: {CalculateRounds(side1, side2, side3, 5000)}");
    }
}
