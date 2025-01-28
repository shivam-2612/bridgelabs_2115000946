using System;

class FootballTeam
{
    static void Main()
    {
        int[] heights = new int[11];
        Random rand = new Random();

        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = rand.Next(150, 251);
        }

        int sum = FindSum(heights);
        double mean = FindMean(sum, heights.Length);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine($"Sum of Heights: {sum}");
        Console.WriteLine($"Mean Height: {mean}");
        Console.WriteLine($"Shortest Height: {shortest}");
        Console.WriteLine($"Tallest Height: {tallest}");
    }

    static int FindSum(int[] heights) => heights.Sum();
    static double FindMean(int sum, int count) => (double)sum / count;
    static int FindShortest(int[] heights) => heights.Min();
    static int FindTallest(int[] heights) => heights.Max();
}
