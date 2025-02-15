using System;
using System.IO;

class Program
{
    static void Main()
    {
        string word = "hello";
        int count = 0;

        using (StreamReader sr = new StreamReader("sample.txt"))
        {
            string content = sr.ReadToEnd();
            count = content.Split(new string[] { word }, StringSplitOptions.None).Length - 1;
        }

        Console.WriteLine($"Word '{word}' appears {count} times.");
    }
}
