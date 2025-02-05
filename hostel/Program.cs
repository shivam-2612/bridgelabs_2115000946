class HotelBooking
{
    public string GuestName { get; }
    public string RoomType { get; }
    public int Nights { get; }

    public HotelBooking()
    {
        GuestName = "Guest";
        RoomType = "Standard";
        Nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    public HotelBooking(HotelBooking other)
    {
        GuestName = other.GuestName;
        RoomType = other.RoomType;
        Nights = other.Nights;
    }
}
