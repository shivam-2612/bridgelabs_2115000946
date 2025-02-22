using System;
using System.Globalization;
using NUnit.Framework;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            throw new FormatException();
        return date.ToString("dd-MM-yyyy");
    }
}

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter formatter;

    [SetUp]
    public void Setup() => formatter = new DateFormatter();

    [Test]
    public void ValidDate() => Assert.AreEqual("25-02-2025", formatter.FormatDate("2025-02-25"));

    [Test]
    public void InvalidDate() => Assert.Throws<FormatException>(() => formatter.FormatDate("25/02/2025"));
}
