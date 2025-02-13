using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    public static int FindLongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longest = Math.Max(longest, currentStreak);
            }
        }

        return longest;
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine(LongestConsecutiveSequence.FindLongestConsecutive(nums));
    }
}
