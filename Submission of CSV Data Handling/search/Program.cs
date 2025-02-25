using System;
using System.IO;

class SearchCSV
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            Console.Write("Enter employee name to search: ");
            string name = Console.ReadLine();
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (data[1].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Department: {data[2]}, Salary: {data[3]}");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }
    }
}
