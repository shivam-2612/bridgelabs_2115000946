using System;
using System.Collections.Generic;

interface riding
{
    string current();
    void update(string location);
}

abstract class Vehicle
{
    private int id1;
    private string name1;
    private double amount;

    public int VehicleId { get => id1; }
    public string DriverName { get => name1; set => name1 = value; }
    public double RatePerKm { get => amount; set => amount = value > 0 ? value : 0; }

    public Vehicle(int id, string driver, double rate)
    {
        this.id1 = id;
        this.DriverName = driver;
        this.RatePerKm = rate;
    }

    public abstract double farecharge(double distance);
    public void details() => Console.WriteLine($"Driver: {DriverName}, Rate: {RatePerKm:C} per km");
}

class Car : Vehicle, riding
{
    private string currentLocation;

    public Car(int id, string driver, double rate) : base(id, driver, rate) { }

    public override double farecharge(double distance) => distance * RatePerKm;
    public string current() => currentLocation;
    public void update(string location) => currentLocation = location;
}

class Program
{
    static void Main()
    {
        Vehicle ride = new Car(1, "Shivam", 10);
        ride.details();
        Console.WriteLine($"Fare for 15 km: {ride.farecharge(15):C}");
    }
}
