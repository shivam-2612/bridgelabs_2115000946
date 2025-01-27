using System;

class Program {
    static void Main() {
        Console.Write("Enter your height in cm: ");
        double heightCm = double.Parse(Console.ReadLine());
        double inches = heightCm / 2.54;
        double feet = (inches / 12);
        Console.WriteLine($"Your Height in cm is {heightCm:F2} while in feet is {feet:F2} and inches is {inches:F2}");
    }
}
