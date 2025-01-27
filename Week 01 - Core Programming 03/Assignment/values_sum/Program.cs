using System;

class Program {
    static void Main() {
        double[] numbers = new double[10];
        double total = 0;
        int index = 0;

        while (true) {
            Console.Write("Enter a number (0 or negative to stop): ");
            double num = double.Parse(Console.ReadLine());
            if (num <= 0 || index == 10) break;

            numbers[index++] = num;
        }

        for (int i = 0; i < index; i++) {
            total += numbers[i];
        }

        Console.WriteLine("Numbers: " + string.Join(", ", numbers[..index]));
        Console.WriteLine($"Sum: {total}");
    }
}
