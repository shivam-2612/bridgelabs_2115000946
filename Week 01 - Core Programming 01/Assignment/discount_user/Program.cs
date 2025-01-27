using System;

class Program {
    static void Main() {
        Console.Write("Enter Student Fee: ");
        double fee = double.Parse(Console.ReadLine());
        Console.Write("Enter Discount Percentage: ");
        double discountPercent = double.Parse(Console.ReadLine());
        double discount = (discountPercent / 100) * fee;
        double finalFee = fee - discount;
        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
    }
}
