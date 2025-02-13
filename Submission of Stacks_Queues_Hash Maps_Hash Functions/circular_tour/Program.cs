using System;

public class CircularTour
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int start = 0, deficit = 0, surplus = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            surplus += petrol[i] - distance[i];
            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        return surplus + deficit >= 0 ? start : -1;
    }
}

class Program
{
    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };
        Console.WriteLine(CircularTour.FindStartingPoint(petrol, distance));
    }
}
