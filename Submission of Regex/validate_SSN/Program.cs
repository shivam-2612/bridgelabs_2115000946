using System;
using System.Text.RegularExpressions;

public class SSNValidator
{
    public bool IsValid(string ssn) => Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$");
}

public class Program
{
    public static void Main()
    {
        var validator = new SSNValidator();
        Console.WriteLine(validator.IsValid("123-45-6789")); // True
        Console.WriteLine(validator.IsValid("123456789"));   // False
    }
}
