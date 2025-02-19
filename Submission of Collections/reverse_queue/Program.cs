﻿using System;
using System.Collections.Generic;

class Program
{
    static Queue<int> ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0) stack.Push(queue.Dequeue());
        while (stack.Count > 0) queue.Enqueue(stack.Pop());
        return queue;
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 10, 20, 30 });
        Console.WriteLine(string.Join(", ", ReverseQueue(queue)));
    }
}
