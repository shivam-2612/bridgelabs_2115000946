using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] digits = number.ToString().ToCharArray().Select(c => c - '0').ToArray();

        Console.WriteLine("Reversed Number: ");
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
    }
}
