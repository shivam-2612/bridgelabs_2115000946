using System;

class Program
{
    public static void Main(String[] args)
    {
        double fee = 125000.00;
		double discountPercent=10.00;
		double discount= ((fee*discountPercent)/100);
		double final=(fee - discount);
		

        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {final:F2}");
    }
}
