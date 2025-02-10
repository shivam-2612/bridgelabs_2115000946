using System;
using System.Collections.Generic;

interface isdistount
{
    double applied();
    string detailss();
}

abstract class foood
{
    private string name_i;
    private double amount_i;
    private int quantity_i;

    public string Item_Name { get => name_i; set => name_i = value; }
    public double Price { get => amount_i; set => amount_i = value > 0 ? value : 0; }
    public int Quantity { get => quantity_i; set => quantity_i = value > 0 ? value : 1; }

    public foood(string name, double amount_i, int quantity_i)
    {
        this.Item_Name = name;
        this.Price = amount_i;
        this.Quantity = quantity_i;
    }

    public abstract double CalculateTotalPrice();
    public void GetItemDetails() => Console.WriteLine($"Item: {Item_Name}, Price: {CalculateTotalPrice():C}");
}

class VegItem : foood, isdistount
{
    public VegItem(string name, double amount_i, int quantity_i) : base(name, amount_i, quantity_i) { }

    public override double CalculateTotalPrice() => Price * Quantity - applied();
    public double applied() => Price * Quantity * 0.1;
    public string deatailss() => "10% discount applied.";
}

class Program
{
    static void Main()
    {
        List<foood> items = new List<foood> { new VegItem("Paneer Tikka", 200, 2) };

        foreach (var item in items)
        {
            item.GetItemDetails();
        }
    }
}
