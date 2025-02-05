using System;

class Book
{
    private static string LibraryName = "City Library";
    private readonly string ISBN;
    private string Title, Author;

    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine($"Library Name: {LibraryName}");
    }

    public void DisplayBookDetails()
    {
        if (this is Book)
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
}
