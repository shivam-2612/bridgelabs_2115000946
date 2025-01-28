using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[,] scores = GenerateScores(numStudents);
        double[,] results = CalculateResults(scores);
        DisplayScorecard(scores, results);
    }

    static int[,] GenerateScores(int numStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numStudents, 3];
        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = random.Next(10, 100);
            scores[i, 1] = random.Next(10, 100);
            scores[i, 2] = random.Next(10, 100);
        }
        return scores;
    }

    static double[,] CalculateResults(int[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 3];
        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;
            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.Write($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t");
            Console.WriteLine($"{results[i, 0]}\t{results[i, 1]:F2}\t{results[i, 2]:F2}%");
        }
    }
}
