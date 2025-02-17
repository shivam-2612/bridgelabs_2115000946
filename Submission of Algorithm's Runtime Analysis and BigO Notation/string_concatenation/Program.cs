using System;
using System.Text;

class StringConcatenationComparison
{
    public static string ConcatenateWithString(int n)
    {
        string result = "";
        for (int i = 0; i < n; i++)
            result += "x";
        return result;
    }

    public static string ConcatenateWithStringBuilder(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("x");
        return sb.ToString();
    }
}
