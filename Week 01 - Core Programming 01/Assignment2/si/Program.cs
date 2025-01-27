using System;

class Program {
    static void Main() {
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter Rate: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter Time: ");
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"The Simple Interest is {simpleInterest:F2} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
