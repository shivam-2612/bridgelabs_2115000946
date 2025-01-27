using System;

class Program {
    static void Main() {
        Console.Write("Enter perimeter of square: ");
        double perimeter = double.Parse(Console.ReadLine());
        double side = perimeter / 4;
        Console.WriteLine($"The length of the side is {side:F2} whose perimeter is {perimeter:F2}");
    }
}
