using System;
using System.Linq;

class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine($"Factors: {string.Join(", ", factors)}");
        Console.WriteLine($"Greatest Factor: {GreatestFactor(factors)}");
        Console.WriteLine($"Sum of Factors: {SumOfFactors(factors)}");
        Console.WriteLine($"Product of Factors: {ProductOfFactors(factors)}");
        Console.WriteLine($"Product of Cube of Factors: {ProductOfCubeOfFactors(factors)}");
        Console.WriteLine($"Is Perfect Number: {IsPerfectNumber(number)}");
        Console.WriteLine($"Is Abundant Number: {IsAbundantNumber(number)}");
        Console.WriteLine($"Is Deficient Number: {IsDeficientNumber(number)}");
        Console.WriteLine($"Is Strong Number: {IsStrongNumber(number)}");
    }

    static int[] FindFactors(int number)
    {
        int[] factors = new int[number];
        int count = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                factors[count] = i;
                count++;
            }
        }
        Array.Resize(ref factors, count);
        return factors;
    }

    static int GreatestFactor(int[] factors)
    {
        return factors.Max();
    }

    static int SumOfFactors(int[] factors)
    {
        return factors.Sum();
    }

    static int ProductOfFactors(int[] factors)
    {
        return factors.Aggregate(1, (prod, factor) => prod * factor);
    }

    static double ProductOfCubeOfFactors(int[] factors)
    {
        return factors.Aggregate(1.0, (prod, factor) => prod * Math.Pow(factor, 3));
    }

    static bool IsPerfectNumber(int number)
    {
        int sumOfFactors = SumOfFactors(FindFactors(number));
        return sumOfFactors == number;
    }

    static bool IsAbundantNumber(int number)
    {
        int sumOfFactors = SumOfFactors(FindFactors(number));
        return sumOfFactors > number;
    }

    static bool IsDeficientNumber(int number)
    {
        int sumOfFactors = SumOfFactors(FindFactors(number));
        return sumOfFactors < number;
    }

    static bool IsStrongNumber(int number)
    {
        int sumOfFactorials = number.ToString().Sum(digit => Factorial(int.Parse(digit.ToString())));
        return sumOfFactorials == number;
    }

    static int Factorial(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
