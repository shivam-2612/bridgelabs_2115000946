class Book
{
    public string Title { get; }
    public string Author { get; }
    public double Price { get; }

    public Book()
    {
        Title = "IGI";
        Author = "Shivam";
        Price = 1400.0;
    }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
}
