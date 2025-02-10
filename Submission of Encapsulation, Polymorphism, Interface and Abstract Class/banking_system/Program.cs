using System;

interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

abstract class BankAccount
{
    private int accountNumber;
    private string holderName;
    private double balance;

    public int AccountNumber { get => accountNumber; }
    public string HolderName { get => holderName; set => holderName = value; }
    public double Balance { get => balance; set => balance = value > 0 ? value : 0; }

    public BankAccount(int number, string name, double balance)
    {
        this.accountNumber = number;
        this.HolderName = name;
        this.Balance = balance;
    }

    public abstract double CalculateInterest();
}

class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(int number, string name, double balance) : base(number, name, balance) { }

    public override double CalculateInterest() => Balance * 0.04;
    public void ApplyForLoan(double amount) { }
    public double CalculateLoanEligibility() => Balance * 10;
}

class Program
{
    static void Main()
    {
        BankAccount account = new SavingsAccount(101, "Shivam", 5000);
        Console.WriteLine($"Interest: {account.CalculateInterest():C}");
    }
}
