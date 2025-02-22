using System;
using System.Text.RegularExpressions;

public class CreditCardValidator
{
    public bool IsValid(string card) => Regex.IsMatch(card, @"^(4\d{15}|5[1-5]\d{14})$");
}

public class Program
{
    public static void Main()
    {
        var validator = new CreditCardValidator();
        Console.WriteLine(validator.IsValid("4111111111111111")); // Visa - True
        Console.WriteLine(validator.IsValid("5111111111111111")); // MasterCard - True
        Console.WriteLine(validator.IsValid("6111111111111111")); // False
    }
}
