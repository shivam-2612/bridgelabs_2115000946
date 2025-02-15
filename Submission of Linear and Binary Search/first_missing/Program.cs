using System;
using System.Linq;

class Program
{
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[temp - 1];
                arr[temp - 1] = temp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1) return i + 1;
        }
        return n + 1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 3, 7, -1, 1, 2 };
        Console.WriteLine(FindFirstMissingPositive(arr));
        Array.Sort(arr);
        Console.WriteLine(BinarySearch(arr, 7));
    }
}
