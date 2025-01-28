using System;

class Program
{
    static double[] CalculateTrigFunctions(double angle)
    {
        double radians = Math.PI * angle / 180.0;
        return new double[] { Math.Sin(radians), Math.Cos(radians), Math.Tan(radians) };
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter angle in degrees:");
        double angle = double.Parse(Console.ReadLine());
        double[] result = CalculateTrigFunctions(angle);
        Console.WriteLine($"Sine: {result[0]}, Cosine: {result[1]}, Tangent: {result[2]}");
    }
}
