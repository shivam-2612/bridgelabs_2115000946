using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean Distance: {distance:F2}");

        double[] lineEquation = GetLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"Equation of the line: y = {lineEquation[0]:F2}x + {lineEquation[1]:F2}");
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double[] GetLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }
}
