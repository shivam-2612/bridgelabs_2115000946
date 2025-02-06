using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();

    public Library(string name)
    {
        Name = name;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("Book A", "Author X");
        Book book2 = new Book("Book B", "Author Y");

        Library library = new Library("City Library");
        library.AddBook(book1);
        library.AddBook(book2);
    }
}
