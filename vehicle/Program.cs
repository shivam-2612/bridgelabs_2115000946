using System;

class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }
    public virtual void DisplayInfo() => Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}");
}

class Car : Vehicle
{
    public int SeatCapacity { get; set; }
    public override void DisplayInfo() => Console.WriteLine($"Car - Max Speed: {MaxSpeed}, Fuel Type: {FuelType}, Seats: {SeatCapacity}");
}

class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }
    public override void DisplayInfo() => Console.WriteLine($"Truck - Max Speed: {MaxSpeed}, Fuel Type: {FuelType}, Payload Capacity: {PayloadCapacity}");
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
    public override void DisplayInfo() => Console.WriteLine($"Motorcycle - Max Speed: {MaxSpeed}, Fuel Type: {FuelType}, Sidecar: {HasSidecar}");
}

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = {
            new Car { MaxSpeed = 200, FuelType = "Petrol", SeatCapacity = 5 },
            new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 10000 },
            new Motorcycle { MaxSpeed = 180, FuelType = "Petrol", HasSidecar = false }
        };

        foreach (var vehicle in vehicles)
            vehicle.DisplayInfo();
    }
}
