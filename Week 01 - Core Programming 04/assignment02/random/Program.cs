using System;

class Program
{
    static void Main()
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);

        double[] result = FindAverageMinMax(randomNumbers);
        Console.WriteLine($"Average: {result[0]}, Min: {result[1]}, Max: {result[2]}");
    }

    static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
            numbers[i] = rand.Next(1000, 10000);

        return numbers;
    }

    static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;
            if (number < min) min = number;
            if (number > max) max = number;
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }
}
