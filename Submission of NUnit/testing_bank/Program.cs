using System;
using NUnit.Framework;

public class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount < 0) throw new ArgumentException();
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance) throw new InvalidOperationException();
        balance -= amount;
    }

    public double GetBalance() => balance;
}

[TestFixture]
public class BankAccountTests
{
    private BankAccount account;

    [SetUp]
    public void Setup() => account = new BankAccount();

    [Test]
    public void DepositTest()
    {
        account.Deposit(100);
        Assert.AreEqual(100, account.GetBalance());
    }

    [Test]
    public void WithdrawTest()
    {
        account.Deposit(200);
        account.Withdraw(50);
        Assert.AreEqual(150, account.GetBalance());
    }

    [Test]
    public void InsufficientFunds() => Assert.Throws<InvalidOperationException>(() => account.Withdraw(50));
}
