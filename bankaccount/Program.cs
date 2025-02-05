class BankAccount
{
    public int AccountNumber { get; }
    protected string AccountHolder { get; }
    private double Balance;

    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public double GetBalance() => Balance;
    public void SetBalance(double amount) => Balance = amount;
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance) { }
}
