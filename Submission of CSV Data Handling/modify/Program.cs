using System;
using System.IO;

class UpdateCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        string newFilePath = "updated_employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (data[2] == "IT")
                {
                    double salary = double.Parse(data[3]);
                    salary += salary * 0.10;
                    data[3] = salary.ToString();
                    lines[i] = string.Join(",", data);
                }
            }
            File.WriteAllLines(newFilePath, lines);
            Console.WriteLine("Salaries updated successfully.");
        }
    }
}
