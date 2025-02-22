using System;
using System.Text.RegularExpressions;

public class EmailExtractor
{
    public void Extract(string text)
    {
        var matches = Regex.Matches(text, @"\b[\w.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}\b");
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}

public class Program
{
    public static void Main()
    {
        var extractor = new EmailExtractor();
        extractor.Extract("Contact us at support@example.com and info@company.org");
    }
}
