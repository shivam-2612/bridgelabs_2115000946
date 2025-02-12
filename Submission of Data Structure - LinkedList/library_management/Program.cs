using System;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool Available;
    public Book Next, Prev;
}

class LibraryManager
{
    private Book head, tail;

    public void AddBook(string title, string author, string genre, int id, bool available, int position = -1)
    {
        Book newBook = new Book { Title = title, Author = author, Genre = genre, BookID = id, Available = available };
        if (head == null || position == 0)
        {
            newBook.Next = head;
            if (head != null) head.Prev = newBook;
            head = newBook;
            if (tail == null) tail = newBook;
            return;
        }
        Book temp = head;
        int index = 1;
        while (temp.Next != null && (position == -1 || index < position))
        {
            temp = temp.Next;
            index++;
        }
        newBook.Next = temp.Next;
        newBook.Prev = temp;
        if (temp.Next != null) temp.Next.Prev = newBook;
        temp.Next = newBook;
        if (newBook.Next == null) tail = newBook;
    }

    public void RemoveBook(int id)
    {
        if (head == null) return;
        if (head.BookID == id)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
            return;
        }
        Book temp = head;
        while (temp.Next != null && temp.Next.BookID != id)
        {
            temp = temp.Next;
        }
        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
            if (temp.Next != null) temp.Next.Prev = temp;
            else tail = temp;
        }
    }

    public void UpdateAvailability(int id, bool status)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == id)
            {
                temp.Available = status;
                return;
            }
            temp = temp.Next;
        }
    }
}
