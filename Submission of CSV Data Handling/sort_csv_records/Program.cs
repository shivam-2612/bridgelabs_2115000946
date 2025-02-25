using System;
using System.IO;
using System.Linq;

class SortCSV
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            var sortedData = lines.Skip(1)
                                  .Select(line => line.Split(','))
                                  .OrderByDescending(data => double.Parse(data[3]))
                                  .Take(5);

            Console.WriteLine("ID\tName\tDepartment\tSalary");
            foreach (var data in sortedData)
            {
                Console.WriteLine($"{data[0]}\t{data[1]}\t{data[2]}\t{data[3]}");
            }
        }
    }
}
