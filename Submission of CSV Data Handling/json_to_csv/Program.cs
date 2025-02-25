using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class JSONCSVConverter
{
    static void Main()
    {
        string jsonFile = "students.json";
        string csvFile = "students.csv";
        string backToJsonFile = "students_back.json";

        if (File.Exists(jsonFile))
        {
            string jsonData = File.ReadAllText(jsonFile);
            var students = JsonSerializer.Deserialize<List<Student>>(jsonData);
            List<string> csvLines = new List<string> { "ID,Name,Age" };
            csvLines.AddRange(students.Select(s => $"{s.ID},{s.Name},{s.Age}"));
            File.WriteAllLines(csvFile, csvLines);
        }

        if (File.Exists(csvFile))
        {
            var csvLines = File.ReadAllLines(csvFile).Skip(1)
                .Select(line => line.Split(','))
                .Select(data => new Student { ID = data[0], Name = data[1], Age = int.Parse(data[2]) })
                .ToList();

            string backToJson = JsonSerializer.Serialize(csvLines, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(backToJsonFile, backToJson);
        }
    }
}
