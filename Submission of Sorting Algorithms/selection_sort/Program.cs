using System;

class SelectionSort
{
    static void Main()
    {
        int[] scores = { 88, 76, 92, 70, 85, 90 };
        for (int i = 0; i < scores.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < scores.Length; j++)
            {
                if (scores[j] < scores[minIndex]) minIndex = j;
            }
            (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
        }
        Console.WriteLine(string.Join(", ", scores));
    }
}
