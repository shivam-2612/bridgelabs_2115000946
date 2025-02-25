using System;
using System.IO;

class ReadCSV
{
    static void Main()
    {
        string filePath = "students.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("ID\tName\tAge\tMarks");
            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] data = lines[i].Split(',');
                Console.WriteLine($"{data[0]}\t{data[1]}\t{data[2]}\t{data[3]}");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
