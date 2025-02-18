using System;

abstract class ProductCategory { }
class BookCategory : ProductCategory { }
class ClothingCategory : ProductCategory { }

class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Marketplace
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product<ProductCategory>
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"{product.Name} discounted price: ${product.Price}");
    }
}

class Program
{
    static void Main()
    {
        Product<BookCategory> book = new Product<BookCategory> { Name = "C# Guide", Price = 50 };
        Marketplace.ApplyDiscount(book, 10);
    }
}
