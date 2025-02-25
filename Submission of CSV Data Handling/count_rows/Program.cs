using System;
using System.IO;

class CountCSVRows
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            int count = lines.Length - 1;
            Console.WriteLine($"Total records: {count}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
