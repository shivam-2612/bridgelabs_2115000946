using System;
using NUnit.Framework;

public class StringUtils
{
    public string Reverse(string str)
    {
        if (str == null) return null;
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string str)
    {
        if (str == null) return false;
        return str.Equals(Reverse(str), StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str) => str?.ToUpper();
}

[TestFixture]
public class StringUtilsTests
{
    private StringUtils utils;

    [SetUp]
    public void Setup() => utils = new StringUtils();

    [Test]
    public void Rev() => Assert.AreEqual("cba", utils.Reverse("abc"));

    [Test]
    public void PalTrue() => Assert.IsTrue(utils.IsPalindrome("madam"));

    [Test]
    public void PalFalse() => Assert.IsFalse(utils.IsPalindrome("hello"));

    [Test]
    public void Upper() => Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
}
