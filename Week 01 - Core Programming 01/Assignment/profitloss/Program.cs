using System;

class Program
{
    public static void Main(String[] args)
    {
        int sellingPrice = 191;
        int costPrice = 129;

        int profit = sellingPrice - costPrice;
        double profitPercentage = ((double)profit / costPrice) * 100;

        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice + 
                          "\nThe Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage.ToString("F2") + "%");
    }
}
