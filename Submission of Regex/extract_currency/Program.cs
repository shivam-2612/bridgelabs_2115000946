using System;
using System.Text.RegularExpressions;

public class CurrencyExtractor
{
    public void Extract(string text)
    {
        var matches = Regex.Matches(text, @"\$\s?\d+(\.\d{2})?");
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}

public class Program
{
    public static void Main()
    {
        var extractor = new CurrencyExtractor();
        extractor.Extract("The price is $45.99, and the discount is $ 10.50.");
    }
}
