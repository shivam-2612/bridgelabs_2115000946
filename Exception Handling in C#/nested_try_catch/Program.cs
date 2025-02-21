using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] array = { 10, 20, 30, 40 };

            Console.Write("Enter array index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.Write("Enter divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int result = array[index] / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
