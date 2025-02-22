using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (password.Length < 8) return false;
        if (!Regex.IsMatch(password, @"[A-Z]")) return false;
        if (!Regex.IsMatch(password, @"\d")) return false;
        return true;
    }
}

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup() => validator = new PasswordValidator();

    [Test]
    public void ValidPass() => Assert.IsTrue(validator.IsValid("Strong1A"));

    [Test]
    public void ShortPass() => Assert.IsFalse(validator.IsValid("S1a"));

    [Test]
    public void NoUppercase() => Assert.IsFalse(validator.IsValid("strong123"));

    [Test]
    public void NoDigit() => Assert.IsFalse(validator.IsValid("StrongPass"));
}
