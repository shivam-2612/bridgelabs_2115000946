using System;

class Program
{
    static void Main()
    {
        int[] numbers = null;

        try
        {
            numbers = new int[] { 10, 20, 30 };
            Console.Write("Enter the index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Value at index {index}: {numbers[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}
