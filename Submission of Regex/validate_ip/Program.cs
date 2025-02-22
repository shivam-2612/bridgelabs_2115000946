using System;
using System.Text.RegularExpressions;

public class IPAddressValidator
{
    public bool IsValid(string ip) => Regex.IsMatch(ip, @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$");
}

public class Program
{
    public static void Main()
    {
        var validator = new IPAddressValidator();
        Console.WriteLine(validator.IsValid("192.168.1.1")); // True
        Console.WriteLine(validator.IsValid("256.100.1.1")); // False
    }
}
