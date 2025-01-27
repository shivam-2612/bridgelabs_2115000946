using System;

class Program {
    static void Main() {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++) {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (var number in numbers) {
            if (number > 0) {
                Console.WriteLine($"{number} is positive and {(number % 2 == 0 ? "even" : "odd")}.");
            } else if (number < 0) {
                Console.WriteLine($"{number} is negative.");
            } else {
                Console.WriteLine("Zero.");
            }
        }

        if (numbers[0] == numbers[^1]) {
            Console.WriteLine("First and last elements are equal.");
        } else if (numbers[0] > numbers[^1]) {
            Console.WriteLine("First element is greater than the last.");
        } else {
            Console.WriteLine("First element is less than the last.");
        }
    }
}
