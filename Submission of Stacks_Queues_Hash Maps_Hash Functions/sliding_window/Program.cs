using System;
using System.Collections.Generic;

public class SlidingWindowMax
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while (deque.Count > 0 && deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);
            if (i >= k - 1)
            {
                result.Add(nums[deque.First.Value]);
            }
        }

        return result.ToArray();
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = SlidingWindowMax.MaxSlidingWindow(nums, k);
        Console.WriteLine(string.Join(" ", result));
    }
}
