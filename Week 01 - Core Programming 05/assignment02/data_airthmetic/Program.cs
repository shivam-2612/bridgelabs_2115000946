using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21);

        Console.WriteLine("Final Date After Operations: " + newDate.ToString("yyyy-MM-dd"));
    }
}
