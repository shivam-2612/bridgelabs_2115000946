using System;

class Program
{
    static void Main()
    {
        string[] sentences = { "Hello world", "C# is fun", "Programming is great" };
        string target = "fun";

        foreach (string sentence in sentences)
        {
            if (sentence.Contains(target))
            {
                Console.WriteLine(sentence);
                break;
            }
        }
    }
}
