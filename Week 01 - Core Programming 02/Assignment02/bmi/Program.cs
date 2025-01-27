using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter weight in kg: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter height in cm: ");
        double height = double.Parse(Console.ReadLine()) / 100;

        double bmi = weight / (height * height);
        string status = bmi <= 18.4 ? "Underweight" : bmi < 25.0 ? "Normal" : bmi < 40 ? "Overweight" : "Obese";

        Console.WriteLine($"BMI: {bmi:F2}");
        Console.WriteLine($"Status: {status}");
    }
}
