using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "InitialKey";
}

class Program
{
    static void Main()
    {
        Type type = typeof(Configuration);
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        field.SetValue(null, "UpdatedKey");
        Console.WriteLine("Modified API_KEY: " + field.GetValue(null));
    }
}
