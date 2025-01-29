using System;

class Program
{
    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;

        int[] freq = new int[256];

        foreach (char c in str1) freq[c]++;
        foreach (char c in str2) freq[c]--;

        foreach (int count in freq)
        {
            if (count != 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();
        Console.WriteLine(AreAnagrams(str1, str2) ? "Anagrams" : "Not Anagrams");
    }
}
