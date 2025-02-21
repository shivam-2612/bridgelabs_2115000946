using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
