using System;

class InsertionSort
{
    static void Main()
    {
        int[] employeeIds = { 102, 98, 123, 87, 76, 150 };
        for (int i = 1; i < employeeIds.Length; i++)
        {
            int key = employeeIds[i];
            int j = i - 1;
            while (j >= 0 && employeeIds[j] > key)
            {
                employeeIds[j + 1] = employeeIds[j];
                j--;
            }
            employeeIds[j + 1] = key;
        }
        Console.WriteLine(string.Join(", ", employeeIds));
    }
}
