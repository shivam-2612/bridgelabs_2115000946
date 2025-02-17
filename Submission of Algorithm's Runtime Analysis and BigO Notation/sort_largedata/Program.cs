using System;

class SortingComparison
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int mid = left + (right - left) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] leftArr = arr[left..(mid + 1)], rightArr = arr[(mid + 1)..(right + 1)];
        int i = 0, j = 0, k = left;
        while (i < leftArr.Length && j < rightArr.Length)
            arr[k++] = leftArr[i] < rightArr[j] ? leftArr[i++] : rightArr[j++];
        while (i < leftArr.Length) arr[k++] = leftArr[i++];
        while (j < rightArr.Length) arr[k++] = rightArr[j++];
    }

    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int pivot = arr[right], partitionIndex = left;
        for (int i = left; i < right; i++)
            if (arr[i] <= pivot)
                (arr[i], arr[partitionIndex]) = (arr[partitionIndex++], arr[i]);
        (arr[partitionIndex], arr[right]) = (arr[right], arr[partitionIndex]);
        QuickSort(arr, left, partitionIndex - 1);
        QuickSort(arr, partitionIndex + 1, right);
    }
}
