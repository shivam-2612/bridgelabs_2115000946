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
        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        bool areCollinearSlope = CheckCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        bool areCollinearArea = CheckCollinearUsingArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine($"Collinear using slope formula: {areCollinearSlope}");
        Console.WriteLine($"Collinear using area formula: {areCollinearArea}");
    }

    static bool CheckCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    static bool CheckCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) < 1e-9;
    }
}
