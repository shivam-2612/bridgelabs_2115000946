using System;

class Program
{
    static void Main()
    {
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

        Console.WriteLine("Current Time in GMT: " + utcTime);
        Console.WriteLine("Current Time in IST: " + istTime);
        Console.WriteLine("Current Time in PST: " + pstTime);
    }
}
