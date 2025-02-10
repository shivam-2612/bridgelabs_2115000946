using System;
using System.Collections.Generic;

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public int ProductId { get => productId; }
    public string Name { get => name; set => name = value; }
    public double Price { get => price; set => price = value > 0 ? value : 0; }

    public Product(int id, string name, double price)
    {
        this.productId = id;
        this.Name = name;
        this.Price = price;
    }

    public abstract double CalculateDiscount();
    public double GetFinalPrice() => Price - CalculateDiscount() + (this is ITaxable taxable ? taxable.CalculateTax() : 0);
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount() => Price * 0.1;
    public double CalculateTax() => Price * 0.18;
    public string GetTaxDetails() => "GST 18% applied.";
}

class Clothing : Product
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount() => Price * 0.15;
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics(1, "Laptop", 1000),
            new Clothing(2, "Shirt", 50)
        };

        foreach (var product in products)
        {
            Console.WriteLine($"Product: {product.Name}, Final Price: {product.GetFinalPrice():C}");
        }
    }
}
