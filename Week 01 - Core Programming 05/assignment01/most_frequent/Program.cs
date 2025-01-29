using System;

class Program
{
    static char MostFrequentChar(string str)
    {
        int[] freq = new int[256];
        char maxChar = str[0];
        int maxCount = 0;

        foreach (char c in str)
        {
            freq[c]++;
            if (freq[c] > maxCount)
            {
                maxCount = freq[c];
                maxChar = c;
            }
        }
        return maxChar;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Most Frequent Character: " + MostFrequentChar(input));
    }
}
