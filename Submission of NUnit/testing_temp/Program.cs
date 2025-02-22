using System;
using NUnit.Framework;

public class TemperatureConverter
{
    public double CToF(double celsius) => (celsius * 9 / 5) + 32;
    public double FToC(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
}

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup() => converter = new TemperatureConverter();

    [Test]
    public void CToFTest() => Assert.AreEqual(32, converter.CToF(0));

    [Test]
    public void FToCTest() => Assert.AreEqual(0, converter.FToC(32));
}
