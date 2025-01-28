using System;
using System.Linq;

class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Is Prime: {IsPrime(number)}");
        Console.WriteLine($"Is Neon Number: {IsNeonNumber(number)}");
        Console.WriteLine($"Is Spy Number: {IsSpyNumber(number)}");
        Console.WriteLine($"Is Automorphic Number: {IsAutomorphicNumber(number)}");
        Console.WriteLine($"Is Buzz Number: {IsBuzzNumber(number)}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sumOfDigits = square.ToString().Sum(digit => int.Parse(digit.ToString()));
        return sumOfDigits == number;
    }

    static bool IsSpyNumber(int number)
    {
        int[] digits = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
        int sum = digits.Sum();
        int product = digits.Aggregate(1, (prod, digit) => prod * digit);
        return sum == product;
    }

    static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number.ToString().EndsWith("7");
    }
}
