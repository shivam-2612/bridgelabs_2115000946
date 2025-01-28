using System;
class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = GetDigits(number);
        Console.WriteLine($"Count of Digits: {digits.Length}");

        int[] reversedDigits = ReverseDigits(digits);
        Console.WriteLine($"Reversed Digits: {string.Join("", reversedDigits)}");

        Console.WriteLine($"Are original digits equal to reversed digits: {CompareArrays(digits, reversedDigits)}");
        Console.WriteLine($"Is Palindrome: {IsPalindrome(digits)}");
        Console.WriteLine($"Is Duck Number: {IsDuckNumber(digits)}");
    }

    static int[] GetDigits(int number) => number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

    static int[] ReverseDigits(int[] digits)
    {
        return digits.Reverse().ToArray();
    }

    static bool CompareArrays(int[] arr1, int[] arr2)
    {
        return arr1.SequenceEqual(arr2);
    }

    static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = ReverseDigits(digits);
        return CompareArrays(digits, reversedDigits);
    }

    static bool IsDuckNumber(int[] digits)
    {
        return digits.Any(digit => digit != 0);
    }
}
