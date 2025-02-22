using System;
using System.Text.RegularExpressions;

public class HexColorValidator
{
    public bool IsValid(string color) => Regex.IsMatch(color, @"^#([A-Fa-f0-9]{6})$");
}

public class Program
{
    public static void Main()
    {
        var validator = new HexColorValidator();

        Console.WriteLine(validator.IsValid("#FFA500")); // True
        Console.WriteLine(validator.IsValid("#ff4500")); // True
        Console.WriteLine(validator.IsValid("#123"));    // False
    }
}
