using System;
using System.IO;

class ReadLargeCSV
{
    static void Main()
    {
        string filePath = "largefile.csv";

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int count = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                    if (count % 100 == 0)
                    {
                        Console.WriteLine($"Processed {count} records.");
                    }
                }
                Console.WriteLine($"Total records processed: {count - 1}");
            }
        }
    }
}
