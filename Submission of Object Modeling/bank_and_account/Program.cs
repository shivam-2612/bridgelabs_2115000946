using System;
using System.Collections.Generic;

class Customer
{
    public string Name { get; set; }
    public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();

    public Customer(string name)
    {
        Name = name;
    }

    public void ViewBalance()
    {
        foreach (var account in Accounts)
        {
            Console.WriteLine($"Account {account.AccountNumber}: {account.Balance}");
        }
    }
}

class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
}

class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; } = new List<Customer>();

    public Bank(string name)
    {
        Name = name;
    }

    public void OpenAccount(Customer customer, BankAccount account)
    {
        customer.Accounts.Add(account);
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank("National Bank");
        Customer customer = new Customer("John Doe");
        BankAccount account = new BankAccount("12345", 1000);
        bank.OpenAccount(customer, account);
        customer.ViewBalance();
    }
}
