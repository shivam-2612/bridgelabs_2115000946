using System;

class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
    public virtual void DisplayAccountType() => Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
}

class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }
    public override void DisplayAccountType() => Console.WriteLine($"Savings Account - Account Number: {AccountNumber}, Balance: {Balance}, Interest Rate: {InterestRate}%");
}

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }
    public override void DisplayAccountType() => Console.WriteLine($"Checking Account - Account Number: {AccountNumber}, Balance: {Balance}, Withdrawal Limit: {WithdrawalLimit}");
}

class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod { get; set; }
    public override void DisplayAccountType() => Console.WriteLine($"Fixed Deposit - Account Number: {AccountNumber}, Balance: {Balance}, Maturity Period: {MaturityPeriod} months");
}

class Program
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount { AccountNumber = 1001, Balance = 5000, InterestRate = 5.5 };
        savings.DisplayAccountType();
    }
}
