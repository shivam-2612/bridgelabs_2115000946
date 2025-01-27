using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] factors = new int[10];
        int index = 0;

        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                if (index == factors.Length) {
                    Array.Resize(ref factors, factors.Length * 2);
                }
                factors[index++] = i;
            }
        }

        Console.WriteLine("Factors: " + string.Join(", ", factors[..index]));
    }
}
