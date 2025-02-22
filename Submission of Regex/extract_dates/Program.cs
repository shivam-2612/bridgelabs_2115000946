using System;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public void Extract(string text)
    {
        var matches = Regex.Matches(text, @"\b\d{2}/\d{2}/\d{4}\b");
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}

public class Program
{
    public static void Main()
    {
        var extractor = new DateExtractor();
        extractor.Extract("The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.");
    }
}
