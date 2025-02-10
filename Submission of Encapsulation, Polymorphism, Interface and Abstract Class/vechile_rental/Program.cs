using System;
using System.Collections.Generic;

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber { get => vehicleNumber; }
    public string Type { get => type; set => type = value; }
    public double RentalRate { get => rentalRate; set => rentalRate = value > 0 ? value : 0; }

    public Vehicle(string number, string type, double rate)
    {
        this.vehicleNumber = number;
        this.Type = type;
        this.RentalRate = rate;
    }

    public abstract double CalculateRentalCost(int days);
}

class Car : Vehicle, IInsurable
{
    public Car(string number, double rate) : base(number, "Car", rate) { }

    public override double CalculateRentalCost(int days) => days * RentalRate;
    public double CalculateInsurance() => 500;
    public string GetInsuranceDetails() => "Comprehensive insurance applied.";
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle> { new Car("UP85AP9143", 50000) };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.Type}, Rental Cost: {vehicle.CalculateRentalCost(5):C}");
        }
    }
}
