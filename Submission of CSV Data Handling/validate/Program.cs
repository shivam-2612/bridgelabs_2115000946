using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSV
{
    static void Main()
    {
        string filePath = "contacts.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Regex phoneRegex = new Regex(@"^\d{10}$");

            Console.WriteLine("Invalid Records:");
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                bool emailValid = emailRegex.IsMatch(data[2]);
                bool phoneValid = phoneRegex.IsMatch(data[3]);

                if (!emailValid || !phoneValid)
                {
                    Console.WriteLine($"Invalid record: {lines[i]}");
                }
            }
        }
    }
}
