﻿using System;

class MergeSort
{
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1, n2 = right - mid;
        int[] leftArr = new int[n1], rightArr = new int[n2];
        for (int i = 0; i < n1; i++) leftArr[i] = arr[left + i];
        for (int j = 0; j < n2; j++) rightArr[j] = arr[mid + 1 + j];

        int i1 = 0, i2 = 0, k = left;
        while (i1 < n1 && i2 < n2) arr[k++] = (leftArr[i1] <= rightArr[i2]) ? leftArr[i1++] : rightArr[i2++];
        while (i1 < n1) arr[k++] = leftArr[i1++];
        while (i2 < n2) arr[k++] = rightArr[i2++];
    }

    static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Main()
    {
        int[] prices = { 150, 90, 200, 50, 120, 175 };
        Sort(prices, 0, prices.Length - 1);
        Console.WriteLine(string.Join(", ", prices));
    }
}
