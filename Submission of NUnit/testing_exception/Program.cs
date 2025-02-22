using System;
using NUnit.Framework;

public class Divider
{
    public int Divide(int a, int b)
    {
        if (b == 0) throw new ArithmeticException();
        return a / b;
    }
}

[TestFixture]
public class DividerTests
{
    private Divider divider;

    [SetUp]
    public void Setup() => divider = new Divider();

    [Test]
    public void Div() => Assert.AreEqual(2, divider.Divide(4, 2));

    [Test]
    public void DivByZero() => Assert.Throws<ArithmeticException>(() => divider.Divide(4, 0));
}
