using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        DisplayCalendar(year, month);
    }

    static void DisplayCalendar(int year, int month)
    {
        string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (IsLeapYear(year)) daysInMonth[1] = 29;
        Console.WriteLine($"\n{monthNames[month - 1]} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        int firstDay = GetFirstDayOfMonth(year, month);
        for (int i = 0; i < firstDay; i++) Console.Write("    ");
        for (int day = 1; day <= daysInMonth[month - 1]; day++)
        {
            Console.Write($"{day,3} ");
            if ((firstDay + day) % 7 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static int GetFirstDayOfMonth(int year, int month)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        return (1 + x + (31 * m0) / 12) % 7;
    }
}
