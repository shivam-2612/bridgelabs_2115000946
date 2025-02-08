using System;

class Order
{
    public int OrderId { get; set; }
    public string OrderDate { get; set; }
    public virtual void GetOrderStatus() => Console.WriteLine($"Order ID: {OrderId}, Date: {OrderDate}, Status: Processing");
}

class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }
    public override void GetOrderStatus() => Console.WriteLine($"Order ID: {OrderId}, Date: {OrderDate}, Tracking: {TrackingNumber}, Status: Shipped");
}

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate { get; set; }
    public override void GetOrderStatus() => Console.WriteLine($"Order ID: {OrderId}, Date: {OrderDate}, Tracking: {TrackingNumber}, Delivered on: {DeliveryDate}");
}

class Program
{
    static void Main()
    {
        DeliveredOrder order = new DeliveredOrder { OrderId = 5001, OrderDate = "2025-02-08", TrackingNumber = "TRK12345", DeliveryDate = "2025-02-10" };
        order.GetOrderStatus();
    }
}
