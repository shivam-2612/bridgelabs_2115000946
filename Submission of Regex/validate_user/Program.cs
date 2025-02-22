using System;
using System.Text.RegularExpressions;

public class UsernameValidator
{
    public bool IsValid(string username) => Regex.IsMatch(username, @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$");
}

public class Program
{
    public static void Main()
    {
        var validator = new UsernameValidator();

        Console.WriteLine(validator.IsValid("user_123")); // True
        Console.WriteLine(validator.IsValid("123user"));  // False
        Console.WriteLine(validator.IsValid("us"));       // False
    }
}
