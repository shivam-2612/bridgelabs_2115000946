using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter marks for Physics: ");
        int physics = int.Parse(Console.ReadLine());
        Console.Write("Enter marks for Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());
        Console.Write("Enter marks for Maths: ");
        int maths = int.Parse(Console.ReadLine());

        int totalMarks = physics + chemistry + maths;
        double percentage = totalMarks / 3.0;

        string grade, remarks;
        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below, but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards (Remedial standards)";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        Console.WriteLine($"Average Marks: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}
