using System;

class Program {
    static void Main() {
        Console.Write("Enter base of triangle in cm: ");
        double baseCm = double.Parse(Console.ReadLine());
        Console.Write("Enter height of triangle in cm: ");
        double heightCm = double.Parse(Console.ReadLine());
        double areaCm2 = 0.5 * baseCm * heightCm;
        double areaInches2 = areaCm2 / Math.Pow(2.54, 2);
        double areaFeet2 = areaInches2 / 144; 
        Console.WriteLine($"The area in cm is {areaCm2:F2}, in feet is {areaFeet2:F2}, and in inches is {areaInches2:F2}");
    }
}
