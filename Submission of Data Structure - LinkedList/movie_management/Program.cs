using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Next, Prev;
}

class MovieManager
{
    private Movie head, tail;

    public void AddMovie(string title, string director, int year, double rating, int position = -1)
    {
        Movie newNode = new Movie { Title = title, Director = director, Year = year, Rating = rating };
        if (head == null || position == 0)
        {
            newNode.Next = head;
            if (head != null) head.Prev = newNode;
            head = newNode;
            if (tail == null) tail = newNode;
            return;
        }
        Movie temp = head;
        int index = 1;
        while (temp.Next != null && (position == -1 || index < position))
        {
            temp = temp.Next;
            index++;
        }
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        if (temp.Next != null) temp.Next.Prev = newNode;
        temp.Next = newNode;
        if (newNode.Next == null) tail = newNode;
    }

    public void RemoveMovie(string title)
    {
        if (head == null) return;
        if (head.Title == title)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
            return;
        }
        Movie temp = head;
        while (temp.Next != null && temp.Next.Title != title)
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

    public Movie SearchMovie(string director)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Director == director) return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void DisplayMovies(bool reverse = false)
    {
        Movie temp = reverse ? tail : head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = reverse ? temp.Prev : temp.Next;
        }
    }

    public void UpdateRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                return;
            }
            temp = temp.Next;
        }
    }
}
