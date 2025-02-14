using System;

class CountingSort
{
    static void Sort(int[] arr)
    {
        int max = 18, min = 10;
        int[] count = new int[max - min + 1], output = new int[arr.Length];
        foreach (var age in arr) count[age - min]++;
        for (int i = 1; i < count.Length; i++) count[i] += count[i - 1];
        for (int i = arr.Length - 1; i >= 0; i--) output[--count[arr[i] - min]] = arr[i];
        Array.Copy(output, arr, arr.Length);
    }

    static void Main()
    {
        int[] ages = { 12, 15, 10, 18, 14, 13, 16, 12 };
        Sort(ages);
        Console.WriteLine(string.Join(", ", ages));
    }
}
