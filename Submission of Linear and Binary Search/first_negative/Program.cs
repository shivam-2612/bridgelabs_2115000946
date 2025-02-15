using System;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 5, -2, 8, -7 };
        foreach (int num in arr)
        {
            if (num < 0)
            {
                Console.WriteLine(num);
                break;
            }
        }
    }
}
