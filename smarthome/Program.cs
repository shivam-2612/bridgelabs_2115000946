using System;

class Device
{
    public int DeviceId { get; set; }
    public string Status { get; set; }
    public virtual void DisplayStatus() => Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
}

class Thermostat : Device
{
    public int TemperatureSetting { get; set; }
    public override void DisplayStatus() => Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}, Temperature: {TemperatureSetting}");
}

class Program
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat { DeviceId = 101, Status = "On", TemperatureSetting = 22 };
        thermostat.DisplayStatus();
    }
}
