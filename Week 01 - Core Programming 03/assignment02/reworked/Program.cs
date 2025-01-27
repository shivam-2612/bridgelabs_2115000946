using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        int maxDigit = 10, index = 0;
        int[] digits = new int[maxDigit];

        while (number > 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }
            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");
    }
}
