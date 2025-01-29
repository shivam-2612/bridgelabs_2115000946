using System;

class Program
{
    static void CountVowelsConsonants(string str)
    {
        int vowels = 0, consonants = 0;
        string vowelSet = "aeiouAEIOU";

        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                if (vowelSet.Contains(c)) vowels++;
                else consonants++;
            }
        }
        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        CountVowelsConsonants(input);
    }
}
