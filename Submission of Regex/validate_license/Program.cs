using System;
using System.Text.RegularExpressions;

public class LicensePlateValidator
{
    public bool IsValid(string plate) => Regex.IsMatch(plate, @"^[A-Z]{2}\d{4}$");
}

public class Program
{
    public static void Main()
    {
        var validator = new LicensePlateValidator();

        Console.WriteLine(validator.IsValid("AB1234")); // True
        Console.WriteLine(validator.IsValid("A12345")); // False
        Console.WriteLine(validator.IsValid("XY5678")); // True
    }
}
