using System;
using System.Collections.Generic;

class Program
{
    static void GenerateBinaryNumbers(int n)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");
        for (int i = 0; i < n; i++)
        {
            string num = queue.Dequeue();
            Console.Write(num + " ");
            queue.Enqueue(num + "0");
            queue.Enqueue(num + "1");
        }
    }

    static void Main()
    {
        GenerateBinaryNumbers(5);
    }
}
