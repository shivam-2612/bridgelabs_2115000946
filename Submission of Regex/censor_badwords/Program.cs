using System;
using System.Text.RegularExpressions;

public class BadWordCensor
{
    public string Censor(string text) => Regex.Replace(text, @"\b(damn|stupid)\b", "****", RegexOptions.IgnoreCase);
}

public class Program
{
    public static void Main()
    {
        var censor = new BadWordCensor();
        Console.WriteLine(censor.Censor("This is a damn bad example with some stupid words."));
    }
}
