using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0) {
            Console.WriteLine("Error: Not a natural number.");
            return;
        }

        int[] evens = new int[number / 2 + 1];
        int[] odds = new int[number / 2 + 1];
        int evenIndex = 0, oddIndex = 0;

        for (int i = 1; i <= number; i++) {
            if (i % 2 == 0) {
                evens[evenIndex++] = i;
            } else {
                odds[oddIndex++] = i;
            }
        }

        Console.WriteLine("Even numbers: " + string.Join(", ", evens[..evenIndex]));
        Console.WriteLine("Odd numbers: " + string.Join(", ", odds[..oddIndex]));
    }
}
