using System;

class Product
{
    private static double Discount = 10.0;
    private readonly int ProductID;
    private string ProductName;
    private double Price;
    private int Quantity;

    public Product(int productId, string productName, double price, int quantity)
    {
        this.ProductID = productId;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public void DisplayProductDetails()
    {
        if (this is Product)
        {
            Console.WriteLine($"Product ID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}, Discount: {Discount}%");
        }
    }
}
