using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "programming";
        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
