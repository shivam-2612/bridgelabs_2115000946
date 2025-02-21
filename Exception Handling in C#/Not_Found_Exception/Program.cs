using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string content = File.ReadAllText("data.txt");
            Console.WriteLine("File Contents:\n" + content);
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
