using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            if (set.Contains(target - num))
            {
                return true;
            }
            set.Add(num);
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 4, 45, 6, 10, 8 };
        int target = 16;
        Console.WriteLine(PairWithGivenSum.HasPairWithSum(arr, target));
    }
}
