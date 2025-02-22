using System;
using NUnit.Framework;

public class NumberChecker
{
    public bool IsEven(int num) => num % 2 == 0;
}

[TestFixture]
public class NumberCheckerTests
{
    private NumberChecker checker;

    [SetUp]
    public void Setup() => checker = new NumberChecker();

    [TestCase(2, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = true)]
    [TestCase(6, ExpectedResult = true)]
    [TestCase(7, ExpectedResult = false)]
    [TestCase(9, ExpectedResult = false)]
    public bool EvenTest(int num) => checker.IsEven(num);
}
