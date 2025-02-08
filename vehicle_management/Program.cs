using System;

interface Refuelable
{
    void Refuel();
}

class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }
}

class ElectricVehicle : Vehicle
{
    public void Charge() => Console.WriteLine($"{Model} is charging.");
}

class PetrolVehicle : Vehicle, Refuelable
{
    public void Refuel() => Console.WriteLine($"{Model} is refueling.");
}

class Program
{
    static void Main()
    {
        ElectricVehicle ev = new ElectricVehicle { Model = "Tesla", MaxSpeed = 200 };
        PetrolVehicle pv = new PetrolVehicle { Model = "Ford", MaxSpeed = 180 };

        ev.Charge();
        pv.Refuel();
    }
}
