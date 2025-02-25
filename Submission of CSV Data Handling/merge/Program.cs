using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MergeCSV
{
    static void Main()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";

        if (File.Exists(file1) && File.Exists(file2))
        {
            var data1 = File.ReadAllLines(file1).Skip(1).Select(line => line.Split(',')).ToDictionary(x => x[0]);
            var data2 = File.ReadAllLines(file2).Skip(1).Select(line => line.Split(',')).ToDictionary(x => x[0]);

            List<string> mergedData = new List<string> { "ID,Name,Age,Marks,Grade" };
            foreach (var id in data1.Keys)
            {
                if (data2.ContainsKey(id))
                {
                    string[] student1 = data1[id];
                    string[] student2 = data2[id];
                    mergedData.Add($"{id},{student1[1]},{student1[2]},{student2[1]},{student2[2]}");
                }
            }

            File.WriteAllLines(outputFile, mergedData);
            Console.WriteLine("Files merged successfully.");
        }
    }
}
