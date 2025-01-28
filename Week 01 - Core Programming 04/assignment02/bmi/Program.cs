using System;

class Program
{
    static void Main()
    {
        double[,] data = new double[10, 3]; // weight, height, BMI

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight (kg) for person {i + 1}: ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write($"Enter height (cm) for person {i + 1}: ");
            data[i, 1] = double.Parse(Console.ReadLine());

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
        }

        string[] status = GetBMIStatus(data);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1} - Weight: {data[i, 0]} kg, Height: {data[i, 1]} cm, BMI: {data[i, 2]:F2}, Status: {status[i]}");
        }
    }

    static double CalculateBMI(double weight, double heightInCm)
    {
        double heightInMeters = heightInCm / 100;
        return weight / (heightInMeters * heightInMeters);
    }

    static string[] GetBMIStatus(double[,] data)
    {
        string[] status = new string[10];
        for (int i = 0; i < 10; i++)
        {
            double bmi = data[i, 2];
            if (bmi < 18.5) status[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9) status[i] = "Normal";
            else if (bmi >= 25 && bmi <= 39.9) status[i] = "Overweight";
            else status[i] = "Obese";
        }
        return status;
    }
}
