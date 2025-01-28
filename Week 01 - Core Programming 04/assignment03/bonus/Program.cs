using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] employeeData = GenerateEmployeeData(10);
        double[,] updatedData = CalculateBonusAndNewSalary(employeeData);
        DisplayResults(employeeData, updatedData);
    }

    static int[,] GenerateEmployeeData(int count)
    {
        Random random = new Random();
        int[,] data = new int[count, 2];
        for (int i = 0; i < count; i++)
        {
            data[i, 0] = random.Next(30000, 99999); 
            data[i, 1] = random.Next(1, 15); 
        }
        return data;
    }

    static double[,] CalculateBonusAndNewSalary(int[,] employeeData)
    {
        double[,] updatedData = new double[employeeData.GetLength(0), 2];
        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            double bonusPercentage = employeeData[i, 1] > 5 ? 0.05 : 0.02;
            double bonus = employeeData[i, 0] * bonusPercentage;
            double newSalary = employeeData[i, 0] + bonus;
            updatedData[i, 0] = bonus;
            updatedData[i, 1] = newSalary;
        }
        return updatedData;
    }

    static void DisplayResults(int[,] employeeData, double[,] updatedData)
    {
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;
        Console.WriteLine("Employee\tOld Salary\tYears of Service\tBonus\t\tNew Salary");
        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            double oldSalary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];
            double bonus = updatedData[i, 0];
            double newSalary = updatedData[i, 1];
            totalOldSalary += oldSalary;
            totalBonus += bonus;
            totalNewSalary += newSalary;
            Console.WriteLine($"{i + 1}\t\t{oldSalary}\t\t{yearsOfService}\t\t\t{bonus:F2}\t\t{newSalary:F2}");
        }
        Console.WriteLine($"\nTotal Old Salary: {totalOldSalary:F2}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:F2}");
        Console.WriteLine($"Total Bonus: {totalBonus:F2}");
    }
}
