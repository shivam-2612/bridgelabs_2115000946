class CarRental
{
    public string CustomerName { get; }
    public string CarModel { get; }
    public int RentalDays { get; }
    public double TotalCost { get; }

    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        TotalCost = rentalDays * dailyRate;
    }
}
