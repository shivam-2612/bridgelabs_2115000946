using System;

class Program
{
    static string RemoveCharacter(string str, char ch)
    {
        char[] result = new char[str.Length];
        int index = 0;

        foreach (char c in str)
        {
            if (c != ch) result[index++] = c;
        }
        return new string(result, 0, index);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter the character to remove: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine("\nModified String: " + RemoveCharacter(input, ch));
    }
}
