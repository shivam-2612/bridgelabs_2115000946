using System;

class Program
{
    static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) || (month == 6 && day <= 20) || (month > 3 && month < 6);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter month:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter day:");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine(IsSpringSeason(month, day) ? "It's a Spring Season" : "Not a Spring Season");
    }
}
