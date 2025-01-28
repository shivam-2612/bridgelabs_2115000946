using System;
class StudentVoteChecker
{
public static bool CanStudentVote(int age)
{
if (age < 0) return false;
return age >= 18;
}
static void Main(string[] args)
{
int[] ages = new int[10];
for (int i = 0; i < 10; i++)
{
Console.WriteLine($"Enter age of student {i + 1}:");
ages[i] = int.Parse(Console.ReadLine());
Console.WriteLine(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote");
}
}
}
