using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] heights = new double[n];
        double[] weights = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter height (m) for person {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter weight (kg) for person {i + 1}: ");
            weights[i] = Convert.ToDouble(Console.ReadLine());

            bmi[i] = weights[i] / (heights[i] * heights[i]);
            status[i] = bmi[i] < 18.5 ? "Underweight" :
                        bmi[i] < 25 ? "Normal" :
                        bmi[i] < 40 ? "Overweight" : "Obese";
        }

        Console.WriteLine("Height\tWeight\tBMI\tStatus");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{heights[i]:0.00}\t{weights[i]:0.00}\t{bmi[i]:0.00}\t{status[i]}");
        }
    }
}
