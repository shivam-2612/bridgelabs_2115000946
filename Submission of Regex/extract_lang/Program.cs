using System;
using System.Text.RegularExpressions;

public class LanguageExtractor
{
    public void Extract(string text)
    {
        var matches = Regex.Matches(text, @"\b(Java|Python|JavaScript|Go)\b");
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}

public class Program
{
    public static void Main()
    {
        var extractor = new LanguageExtractor();
        extractor.Extract("I love Java, Python, and JavaScript, but I haven't tried Go yet.");
    }
}
