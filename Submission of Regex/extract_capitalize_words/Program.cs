using System;
using System.Text.RegularExpressions;

public class CapitalizedWordExtractor
{
    public void Extract(string text)
    {
        var matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}

public class Program
{
    public static void Main()
    {
        var extractor = new CapitalizedWordExtractor();
        extractor.Extract("The Eiffel Tower is in Paris and the Statue of Liberty is in New York.");
    }
}
