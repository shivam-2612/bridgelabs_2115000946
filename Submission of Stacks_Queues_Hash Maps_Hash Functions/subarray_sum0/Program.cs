using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    public static int CountZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0, count = 0;
        map[0] = 1;

        foreach (int num in arr)
        {
            sum += num;
            if (map.ContainsKey(sum))
            {
                count += map[sum];
            }
            if (!map.ContainsKey(sum))
            {
                map[sum] = 0;
            }
            map[sum]++;
        }

        return count;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 4, 2, -3, 1, 6 };
        Console.WriteLine(ZeroSumSubarrays.CountZeroSumSubarrays(arr));
    }
}
