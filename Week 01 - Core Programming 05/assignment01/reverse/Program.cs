using System;

class Program
{
    static string ReverseString(string str)
    {
        char[] arr = str.ToCharArray();
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            char temp = arr[left];
            arr[left++] = arr[right];
            arr[right--] = temp;
        }
        return new string(arr);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Reversed String: " + ReverseString(input));
    }
}
