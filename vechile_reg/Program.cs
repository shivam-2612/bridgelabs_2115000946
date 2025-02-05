using System;

class Vehicle
{
    private static double RegistrationFee = 500.0;
    private readonly string RegistrationNumber;
    private string OwnerName, VehicleType;

    public Vehicle(string registrationNumber, string ownerName, string vehicleType)
    {
        this.RegistrationNumber = registrationNumber;
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    public void DisplayVehicleDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine($"Registration Number: {RegistrationNumber}, Owner: {OwnerName}, Vehicle Type: {VehicleType}, Fee: {RegistrationFee}");
        }
    }
}
