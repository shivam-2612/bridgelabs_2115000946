using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Amar's age: ");
        int age1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height: ");
        int height1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int age2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height: ");
        int height2 = int.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int age3 = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height: ");
        int height3 = int.Parse(Console.ReadLine());

        int youngestAge = Math.Min(age1, Math.Min(age2, age3));
        int tallestHeight = Math.Max(height1, Math.Max(height2, height3));

        if (youngestAge == age1)
            Console.WriteLine("The youngest friend is Amar.");
        else if (youngestAge == age2)
            Console.WriteLine("The youngest friend is Akbar.");
        else
            Console.WriteLine("The youngest friend  is Anthony.");

        if (tallestHeight == height1)
            Console.WriteLine("The tallest friend is Amar.");
        else if (tallestHeight == height2)
            Console.WriteLine("The tallest friend is Akbar.");
        else
            Console.WriteLine("The tallest friend is Anthony.");
    }
}