using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        
        for (int i = 1; i < number; i++) {
            if (number % i == 0) {
                sum += i;
            }
        }
        
        Console.WriteLine(sum > number ? "Abundant Number" : "Not an Abundant Number");
    }
}
