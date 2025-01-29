using System;

class Program
{
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        char[] result = new char[sentence.Length + (newWord.Length - oldWord.Length) * 10];
        int i = 0, j = 0;

        while (i < sentence.Length)
        {
            int k = 0;
            while (i + k < sentence.Length && k < oldWord.Length && sentence[i + k] == oldWord[k])
                k++;

            if (k == oldWord.Length && (i + k == sentence.Length || sentence[i + k] == ' '))
            {
                foreach (char c in newWord) result[j++] = c;
                i += oldWord.Length;
            }
            else
            {
                result[j++] = sentence[i++];
            }
        }
        return new string(result, 0, j);
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();
        Console.WriteLine("Modified Sentence: " + ReplaceWord(sentence, oldWord, newWord));
    }
}
