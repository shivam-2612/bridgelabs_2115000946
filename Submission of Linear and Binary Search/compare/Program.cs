using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int iterations = 10000;
        Stopwatch sw = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += "a";
        }
        sw.Stop();
        Console.WriteLine("String Concatenation: " + sw.ElapsedMilliseconds + "ms");

        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }
        sw.Stop();
        Console.WriteLine("StringBuilder: " + sw.ElapsedMilliseconds + "ms");
    }
}
