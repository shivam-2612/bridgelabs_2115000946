using System;

class Program {
    static void Main() {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter fromCity: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter viaCity: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter toCity: ");
        string toCity = Console.ReadLine();
        Console.Write("Enter distance from fromCity to viaCity (in miles): ");
        double fromToVia = double.Parse(Console.ReadLine());
        Console.Write("Enter distance from viaCity to toCity (in miles): ");
        double viaToFinalCity = double.Parse(Console.ReadLine());
        double totalDistance = fromToVia + viaToFinalCity;
        Console.WriteLine($"The results of the trip are: {name}, Total Distance: {totalDistance} miles, Cities: {fromCity}, {viaCity}, {toCity}");
    }
}
