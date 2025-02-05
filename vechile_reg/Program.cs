class Vehicle
{
    public string OwnerName { get; }
    public string VehicleType { get; }
    private static double registrationFee = 500.0;

    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {OwnerName}, Vehicle: {VehicleType}");
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}
