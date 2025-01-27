using System;

class Program {
    static void Main() {
        Console.Write("Enter distance in feet: ");
        double distanceInFeet = double.Parse(Console.ReadLine());
        double yards = distanceInFeet / 3;
        double miles = yards / 1760;
        Console.WriteLine($"Distance in yards {yards:F2} and in miles {miles:F2}");
    }
}
