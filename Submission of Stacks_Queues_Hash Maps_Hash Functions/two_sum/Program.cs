using System;
using System.Collections.Generic;

public class TwoSumProblem
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }

        return new int[] { };
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        Console.WriteLine(string.Join(" ", TwoSumProblem.TwoSum(nums, target)));
    }
}
