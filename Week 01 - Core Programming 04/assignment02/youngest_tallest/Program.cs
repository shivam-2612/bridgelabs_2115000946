using System;

class Program
{
static void Main(string[] args)
{
int[] ages = new int[3];
double[] heights = new double[3];

for (int i = 0; i < 3; i++)
{
Console.WriteLine($"Enter age and height for friend {i + 1}:");
ages[i] = int.Parse(Console.ReadLine());
heights[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("Youngest: " + FindYoungest(ages));
Console.WriteLine("Tallest: " + FindTallest(heights));
}

static int FindYoungest(int[] ages)
{
int youngest = ages[0];
for (int i = 1; i < ages.Length; i++)
if (ages[i] < youngest) youngest = ages[i];
return youngest;
}

static double FindTallest(double[] heights)
{
double tallest = heights[0];
for (int i = 1; i < heights.Length; i++)
if (heights[i] > tallest) tallest = heights[i];
return tallest;
}
}
