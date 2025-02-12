using System;

class Item
{
    public string Name;
    public int ID;
    public int Quantity;
    public double Price;
    public Item Next;
}

class InventoryManager
{
    private Item head;

    public void AddItem(string name, int id, int qty, double price, int position = -1)
    {
        Item newItem = new Item { Name = name, ID = id, Quantity = qty, Price = price };
        if (head == null || position == 0)
        {
            newItem.Next = head;
            head = newItem;
            return;
        }
        Item temp = head;
        int index = 1;
        while (temp.Next != null && (position == -1 || index < position))
        {
            temp = temp.Next;
            index++;
        }
        newItem.Next = temp.Next;
        temp.Next = newItem;
    }

    public void RemoveItem(int id)
    {
        if (head == null) return;
        if (head.ID == id)
        {
            head = head.Next;
            return;
        }
        Item temp = head;
        while (temp.Next != null && temp.Next.ID != id)
        {
            temp = temp.Next;
        }
        if (temp.Next != null) temp.Next = temp.Next.Next;
    }

    public void UpdateQuantity(int id, int newQty)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ID == id)
            {
                temp.Quantity = newQty;
                return;
            }
            temp = temp.Next;
        }
    }

    public Item SearchItem(int id)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ID == id) return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void DisplayTotalInventoryValue()
    {
        double total = 0;
        Item temp = head;
        while (temp != null)
        {
            total += temp.Quantity * temp.Price;
            temp = temp.Next;
        }
        Console.WriteLine($"Total Inventory Value: {total}");
    }
}
