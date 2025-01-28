using System;
class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = GetDigits(number);
        Console.WriteLine($"Count of Digits: {digits.Length}");
        Console.WriteLine($"Sum of Digits: {FindSumOfDigits(digits)}");
        Console.WriteLine($"Sum of Squares of Digits: {FindSumOfSquaresOfDigits(digits)}");
        Console.WriteLine($"Is Harshad Number: {IsHarshadNumber(digits, number)}");

        int[,] digitFrequency = FindDigitFrequency(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < digitFrequency.GetLength(0); i++)
        {
            Console.WriteLine($"Digit {digitFrequency[i, 0]}: {digitFrequency[i, 1]} times");
        }
    }

    static int[] GetDigits(int number) => number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

    static int FindSumOfDigits(int[] digits) => digits.Sum();

    static double FindSumOfSquaresOfDigits(int[] digits) => digits.Sum(digit => Math.Pow(digit, 2));

    static bool IsHarshadNumber(int[] digits, int number)
    {
        int sumOfDigits = FindSumOfDigits(digits);
        return sumOfDigits != 0 && number % sumOfDigits == 0;
    }

    static int[,] FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];

        foreach (var digit in digits)
        {
            frequency[digit, 0] = digit;
            frequency[digit, 1]++;
        }

        return frequency.Cast<int>().Distinct().ToArray().Length;
    }
}
