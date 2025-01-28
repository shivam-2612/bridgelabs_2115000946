using System;

class Program
{
    static double CalculateWindChill(double temp, double windSpeed)
    {
        return 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature and wind speed:");
        double temp = double.Parse(Console.ReadLine());
        double windSpeed = double.Parse(Console.ReadLine());
        Console.WriteLine($"Wind chill temperature: {CalculateWindChill(temp, windSpeed)}");
    }
}
