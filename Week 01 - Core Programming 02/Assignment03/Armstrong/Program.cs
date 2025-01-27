using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0, originalNumber = number;
        
        while (originalNumber != 0) {
            int digit = originalNumber % 10;
            sum += digit * digit * digit;
            originalNumber /= 10;
        }
        
        Console.WriteLine(sum == number ? "Armstrong Number" : "Not an Armstrong Number");
    }
}
