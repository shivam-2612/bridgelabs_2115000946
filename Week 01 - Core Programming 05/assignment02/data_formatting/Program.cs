using System;

class Program
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Format 1 (dd/MM/yyyy): " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Format 2 (yyyy-MM-dd): " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Format 3 (EEE, MMM dd, yyyy): " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}
