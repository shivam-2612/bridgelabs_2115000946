using System;

class Program
{
    static string ToggleCase(string str)
    {
        char[] arr = str.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = char.IsUpper(arr[i]) ? char.ToLower(arr[i]) : char.ToUpper(arr[i]);
        }
        return new string(arr);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Toggled Case: " + ToggleCase(input));
    }
}
