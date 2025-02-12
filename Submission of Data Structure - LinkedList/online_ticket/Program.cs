using System;

class Ticket
{
    public int TicketID;
    public string Customer;
    public string Movie;
    public int Seat;
    public DateTime BookingTime;
    public Ticket Next;
}

class TicketSystem
{
    private Ticket head, tail;

    public void BookTicket(int id, string customer, string movie, int seat, DateTime time)
    {
        Ticket newTicket = new Ticket { TicketID = id, Customer = customer, Movie = movie, Seat = seat, BookingTime = time };
        if (head == null)
        {
            head = tail = newTicket;
            tail.Next = head;
            return;
        }
        tail.Next = newTicket;
        tail = newTicket;
        tail.Next = head;
    }
}
