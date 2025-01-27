using System;

class Program
{
    static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter age of friend {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter height of friend {i + 1} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;
            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        Console.WriteLine($"Youngest: Friend {youngestIndex + 1} (Age: {ages[youngestIndex]})");
        Console.WriteLine($"Tallest: Friend {tallestIndex + 1} (Height: {heights[tallestIndex]} cm)");
    }
}
