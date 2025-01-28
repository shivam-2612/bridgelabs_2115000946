using System;

class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = GetDigits(number);
        Console.WriteLine($"Count of Digits: {digits.Length}");
        Console.WriteLine($"Is Duck Number: {IsDuckNumber(digits)}");
        Console.WriteLine($"Is Armstrong Number: {IsArmstrongNumber(digits, number)}");
        Console.WriteLine($"Largest Digit: {FindLargest(digits)}");
        Console.WriteLine($"Smallest Digit: {FindSmallest(digits)}");
    }

    static int[] GetDigits(int number) => number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    static bool IsDuckNumber(int[] digits) => digits.Any(digit => digit != 0);
    static bool IsArmstrongNumber(int[] digits, int number) => digits.Sum(digit => (int)Math.Pow(digit, digits.Length)) == number;
    static int FindLargest(int[] digits) => digits.Max();
    static int FindSmallest(int[] digits) => digits.Min();
}
