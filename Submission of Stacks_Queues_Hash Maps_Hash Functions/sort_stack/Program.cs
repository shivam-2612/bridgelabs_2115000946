using System;
using System.Collections.Generic;

public class StackSorter
{
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, temp);
        }
    }

    private static void InsertSorted(Stack<int> stack, int item)
    {
        if (stack.Count == 0 || stack.Peek() <= item)
        {
            stack.Push(item);
        }
        else
        {
            int temp = stack.Pop();
            InsertSorted(stack, item);
            stack.Push(temp);
        }
    }
}

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>(new int[] { 3, 1, 4, 2 });
        StackSorter.SortStack(stack);
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
