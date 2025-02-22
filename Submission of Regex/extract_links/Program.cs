using System;
using System.Text.RegularExpressions;

public class LinkExtractor
{
    public void Extract(string text)
    {
        var matches = Regex.Matches(text, @"https?:\/\/[^\s]+");
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}

public class Program
{
    public static void Main()
    {
        var extractor = new LinkExtractor();
        extractor.Extract("Visit https://www.google.com and http://example.org for more info.");
    }
}
