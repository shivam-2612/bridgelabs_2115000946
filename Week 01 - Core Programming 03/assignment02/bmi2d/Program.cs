using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[][] personData = new double[n][];
        string[] weightStatus = new string[n];

        for (int i = 0; i < n; i++)
        {
            personData[i] = new double[3];
            Console.WriteLine($"Enter height (m) for person {i + 1}: ");
            personData[i][0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter weight (kg) for person {i + 1}: ");
            personData[i][1] = Convert.ToDouble(Console.ReadLine());

            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]);
            weightStatus[i] = personData[i][2] < 18.5 ? "Underweight" :
                              personData[i][2] < 25 ? "Normal" :
                              personData[i][2] < 40 ? "Overweight" : "Obese";
        }

        Console.WriteLine("Height(m)\tWeight(kg)\tBMI\t\tStatus");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{personData[i][0]:0.00}\t\t{personData[i][1]:0.00}\t\t{personData[i][2]:0.00}\t\t{weightStatus[i]}");
        }
    }
}
