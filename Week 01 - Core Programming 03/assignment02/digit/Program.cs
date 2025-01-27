using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        int[] frequency = new int[10];

        while (number > 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        Console.WriteLine("Digit\tFrequency");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"{i}\t{frequency[i]}");
            }
        }
    }
}
