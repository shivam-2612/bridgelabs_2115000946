using System;

class Program
{
    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[mid + 1])
                right = mid;
            else
                left = mid + 1;
        }
        return left;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 7, 8, 6 };
        Console.WriteLine(FindPeakElement(arr));
    }
}
