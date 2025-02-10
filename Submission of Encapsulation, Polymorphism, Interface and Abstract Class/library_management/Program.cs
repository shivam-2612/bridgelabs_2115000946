using System;

interface reverse_lib
{
    void reversing();
    bool isavaliable();
}

abstract class item1
{
    private int id1;
    private string name1;
    private string writer;

    public int ItemId { get => id1; }
    public string Title { get => name1; set => name1 = value; }
    public string Author { get => writer; set => writer = value; }

    public item1(int id, string name1, string writer)
    {
        this.id1 = id;
        this.Title = name1;
        this.Author = writer;
    }

    public abstract int loantime();
}

class Book : item1
{
    public Book(int id, string name1, string writer) : base(id, name1, writer) { }

    public override int loantime() => 14;
}

class Program
{
    static void Main()
    {
        item1 book = new Book(1, "C# Programming", "Author Ram");
        Console.WriteLine($"Loan Duration: {book.loantime()} days");
    }
}
