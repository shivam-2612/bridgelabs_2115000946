class Book
{
    public string ISBN { get; }
    protected string Title { get; }
    private string Author;

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public string GetAuthor() => Author;
    public void SetAuthor(string author) => Author = author;
}

class EBook : Book
{
    public EBook(string isbn, string title, string author) : base(isbn, title, author) { }
}
