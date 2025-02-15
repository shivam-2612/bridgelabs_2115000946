using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text to save:");
        string input = Console.ReadLine();
        File.WriteAllText("output.txt", input);
        Console.WriteLine("Data written to file.");
    }
}
