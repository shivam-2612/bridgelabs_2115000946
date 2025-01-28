using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0)
            Console.WriteLine("No real roots");
        else if (roots.Length == 1)
            Console.WriteLine($"One root: {roots[0]}");
        else
            Console.WriteLine($"Two roots: {roots[0]}, {roots[1]}");
    }

    static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0)
            return new double[0];
        else if (delta == 0)
            return new double[] { -b / (2 * a) };
        else
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
    }
}
