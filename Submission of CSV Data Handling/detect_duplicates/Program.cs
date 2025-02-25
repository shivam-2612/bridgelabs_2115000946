using System;
using System.Collections.Generic;
using System.IO;

class DetectDuplicates
{
    static void Main()
    {
        string filePath = "students.csv";

        if (File.Exists(filePath))
        {
            HashSet<string> ids = new HashSet<string>();
            List<string> duplicates = new List<string>();

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (!ids.Add(data[0]))
                {
                    duplicates.Add(lines[i]);
                }
            }

            Console.WriteLine("Duplicate Records:");
            foreach (var record in duplicates)
            {
                Console.WriteLine(record);
            }
        }
    }
}
