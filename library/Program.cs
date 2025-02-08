using System;

class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public virtual void DisplayInfo() => Console.WriteLine($"Title: {Title}, Year: {PublicationYear}");
}

class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }
    public override void DisplayInfo() => Console.Wri
