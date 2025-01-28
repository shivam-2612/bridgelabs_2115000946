using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of students:");
        int numberOfStudents = int.Parse(Console.ReadLine());
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine($"The number of possible handshakes: {handshakes}");
    }
}
