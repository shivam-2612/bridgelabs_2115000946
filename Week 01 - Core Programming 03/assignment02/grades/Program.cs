using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        double[] physics = new double[numStudents];
        double[] chemistry = new double[numStudents];
        double[] maths = new double[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}: ");
            
            physics[i] = GetValidMarks("Physics");
            chemistry[i] = GetValidMarks("Chemistry");
            maths[i] = GetValidMarks("Maths");

            percentages[i] = (physics[i] + chemistry[i] + maths[i]) / 3;
            grades[i] = GetGrade(percentages[i]);
        }

        Console.WriteLine("\nMarks and Grades of Students:");
        Console.WriteLine("Physics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{physics[i]}\t{chemistry[i]}\t\t{maths[i]}\t{percentages[i]:0.00}%\t\t{grades[i]}");
        }
    }

    static double GetValidMarks(string subject)
    {
        Console.WriteLine($"Enter marks for {subject}: ");
        double marks = Convert.ToDouble(Console.ReadLine());
        while (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid input. Please enter marks between 0 and 100.");
            marks = Convert.ToDouble(Console.ReadLine());
        }
        return marks;
    }

    static string GetGrade(double percentage)
    {
        if (percentage >= 80) return "A";
        else if (percentage >= 70) return "B";
        else if (percentage >= 60) return "C";
        else if (percentage >= 50) return "D";
        else if (percentage >= 40) return "E";
        else return "R";
    }
}
