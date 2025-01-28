using System;

class Program
{
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter Principal:");
        double principal = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Rate:");
        double rate = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Time:");
        double time = double.Parse(Console.ReadLine());
        Console.WriteLine($"The Simple Interest is {CalculateSimpleInterest(principal, rate, time)} for Principal {principal}, Rate of Interest {rate}, and Time {time}");
    }
}
