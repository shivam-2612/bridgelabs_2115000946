using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int count = 0;
        
        while (number != 0) {
            number /= 10;
            count++;
        }
        
        Console.WriteLine($"Number of digits: {count}");
    }
}
