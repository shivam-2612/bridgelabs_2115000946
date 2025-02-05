class Product
{
    public string ProductName { get; }
    public double Price { get; }
    private static int totalProducts;

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        totalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product: {ProductName}, Price: {Price}");
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {totalProducts}");
    }
}
