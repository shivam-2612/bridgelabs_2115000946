using System;

class Program
{
    static void Main()
    {
        int low = 1, high = 100, guess;
        string feedback;

        Console.WriteLine("Think of a number between 1 and 100.");
        
        while (true)
        {
            guess = (low + high) / 2;
            Console.Write($"Is your number {guess}? (Enter 'high', 'low', 'correct'): ");
            feedback = Console.ReadLine().ToLower();

            if (feedback == "correct") break;
            else if (feedback == "high") high = guess - 1;
            else if (feedback == "low") low = guess + 1;
        }
        
        Console.WriteLine($"Your number is {guess}!");
    }
}
