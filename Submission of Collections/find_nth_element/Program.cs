using System;
using System.Collections.Generic;

class Program
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string> fast = list.First, slow = list.First;
        for (int i = 0; i < n; i++) fast = fast?.Next;
        while (fast != null) { fast = fast.Next; slow = slow.Next; }
        return slow?.Value ?? "Not Found";
    }

    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>(new[] { "A", "B", "C", "D", "E" });
        Console.WriteLine(FindNthFromEnd(list, 2));
    }
}
