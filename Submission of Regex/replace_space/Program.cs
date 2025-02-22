using System;
using System.Text.RegularExpressions;

public class SpaceReplacer
{
    public string Replace(string text) => Regex.Replace(text, @"\s{2,}", " ");
}

public class Program
{
    public static void Main()
    {
        var replacer = new SpaceReplacer();
        Console.WriteLine(replacer.Replace("This  is   an  example    with multiple    spaces."));
    }
}
