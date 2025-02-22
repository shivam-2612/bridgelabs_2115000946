using System;
using System.Text.RegularExpressions;

public class RepeatingWordFinder
{
    public void FindRepeats(string text)
    {
        var matches = Regex.Matches(text, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);
        foreach (Match match in matches)
            Console.WriteLine(match.Groups[1].Value);
    }
}

public class Program
{
    public static void Main()
    {
        var finder = new RepeatingWordFinder();
        finder.FindRepeats("This is is a repeated repeated word test.");
    }
}
