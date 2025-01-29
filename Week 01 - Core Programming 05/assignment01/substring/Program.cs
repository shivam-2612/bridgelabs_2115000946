using System;

class Program
{
    static int CountSubstring(string str, string sub)
    {
        int count = 0, index = 0;
        while ((index = str.IndexOf(sub, index)) != -1)
        {
            count++;
            index += sub.Length;
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.Write("Enter a substring to count: ");
        string sub = Console.ReadLine();
        Console.WriteLine("Occurrences: " + CountSubstring(str, sub));
    }
}
