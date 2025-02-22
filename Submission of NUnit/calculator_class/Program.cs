using System;
using NUnit.Framework;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
}

[TestFixture]
public class CalculatorTests
{
    private Calculator calc;

    [SetUp]
    public void Setup() => calc = new Calculator();

    [Test]
    public void Add() => Assert.AreEqual(5, calc.Add(2, 3));

    [Test]
    public void Sub() => Assert.AreEqual(1, calc.Subtract(4, 3));

    [Test]
    public void Mul() => Assert.AreEqual(12, calc.Multiply(3, 4));

    [Test]
    public void Div() => Assert.AreEqual(2, calc.Divide(6, 3));

    [Test]
    public void DivByZero() => Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
}
