using System;

class BankAccount
{
    private static int totalAccounts = 0;
    private static string bankName = "Global Bank";
    private readonly int AccountNumber;
    private string AccountHolderName;
    
    public BankAccount(int accountNumber, string accountHolderName)
    {
        this.AccountNumber = accountNumber;
        this.AccountHolderName = accountHolderName;
        totalAccounts++;
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine($"Total Accounts: {totalAccounts}");
    }

    public void DisplayAccountDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine($"Account Holder: {AccountHolderName}, Account Number: {AccountNumber}, Bank: {bankName}");
        }
    }
}
