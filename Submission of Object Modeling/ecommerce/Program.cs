using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

class Order
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
}

class Customer
{
    public string Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer("Alice");
        Order order = new Order();
        order.AddProduct(new Product("Laptop"));
    }
}
