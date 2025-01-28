using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
            if (IsPositive(numbers[i]))
            {
                Console.WriteLine("Positive number");
                if (IsEven(numbers[i])) Console.WriteLine("Even number");
                else Console.WriteLine("Odd number");
            }
            else
                Console.WriteLine("Negative number");
        }

        int result = Compare(numbers[0], numbers[4]);
        if (result > 0)
            Console.WriteLine("First element is greater than last element");
        else if (result == 0)
            Console.WriteLine("First element is equal to last element");
        else
            Console.WriteLine("First element is less than last element");
    }

    static bool IsPositive(int number) => number > 0;

    static bool IsEven(int number) => number % 2 == 0;

    static int Compare(int num1, int num2)
    {
       
