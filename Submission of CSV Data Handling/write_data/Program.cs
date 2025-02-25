using System;
using System.IO;

class WriteCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        string[] employees = {
            "ID,Name,Department,Salary",
            "1,John Doe,IT,60000",
            "2,Jane Smith,HR,55000",
            "3,Michael Johnson,Finance,70000",
            "4,Linda Brown,Marketing,65000",
            "5,Robert Davis,IT,72000"
        };
        File.WriteAllLines(filePath, employees);
        Console.WriteLine("CSV file created successfully.");
    }
}
