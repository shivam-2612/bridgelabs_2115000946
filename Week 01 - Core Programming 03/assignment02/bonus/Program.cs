using System;

class Program
{
    static void Main()
    {
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter salary for employee {i + 1}: ");
            salaries[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter years of service for employee {i + 1}: ");
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

            if (salaries[i] <= 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please re-enter.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            bonuses[i] = (yearsOfService[i] > 5) ? salaries[i] * 0.05 : salaries[i] * 0.02;
            newSalaries[i] = salaries[i] + bonuses[i];
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine($"Total Bonus: {totalBonus}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}
