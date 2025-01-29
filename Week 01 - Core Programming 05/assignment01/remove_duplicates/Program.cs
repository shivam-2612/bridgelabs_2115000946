using System;

class Program
{
    static string RemoveDuplicates(string str)
    {
        string result = "";
        foreach (char c in str)
        {
            if (!result.Contains(c)) result += c;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Modified String: " + RemoveDuplicates(input));
    }
}
