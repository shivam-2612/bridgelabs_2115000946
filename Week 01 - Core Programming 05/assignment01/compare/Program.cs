using System;

class Program
{
    static string CompareStrings(string str1, string str2)
    {
        int len = Math.Min(str1.Length, str2.Length);
        for (int i = 0; i < len; i++)
        {
            if (str1[i] < str2[i]) return $"{str1} comes before {str2}";
            if (str1[i] > str2[i]) return $"{str2} comes before {str1}";
        }
        return str1.Length < str2.Length ? $"{str1} comes before {str2}" : $"{str2} comes before {str1}";
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();
        Console.WriteLine(CompareStrings(str1, str2));
    }
}
