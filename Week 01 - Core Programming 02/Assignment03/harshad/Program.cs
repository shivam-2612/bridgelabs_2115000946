using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0, originalNumber = number;
        
        while (originalNumber != 0) {
            sum += originalNumber % 10;
            originalNumber /= 10;
        }
        
        Console.WriteLine(number % sum == 0 ? "Harshad Number" : "Not a Harshad Number");
    }
}
