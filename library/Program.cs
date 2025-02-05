class LibraryBook
{
    public string Title { get; }
    public string Author { get; }
    public double Price { get; }
    public bool IsAvailable { get; private set; }

    public LibraryBook(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        if (IsAvailable)
            IsAvailable = false;
    }
}
