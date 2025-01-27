using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] results = new int[4 * 10];

        for (int i = 6; i <= 9; i++) {
            for (int j = 1; j <= 10; j++) {
                results[(i - 6) * 10 + (j - 1)] = i * j;
            }
        }

        for (int i = 6; i <= 9; i++) {
            for (int j = 1; j <= 10; j++) {
                Console.WriteLine($"{i} * {j} = {results[(i - 6) * 10 + (j - 1)]}");
            }
        }
    }
}
