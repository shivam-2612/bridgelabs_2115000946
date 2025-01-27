using System;

class Program {
    static void Main() {
        Console.Write("Enter unit price: ");
        double unitPrice = double.Parse(Console.ReadLine());
        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        double totalPrice = unitPrice * quantity;
        Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity {quantity} and unit price is INR {unitPrice:F2}");
    }
}
