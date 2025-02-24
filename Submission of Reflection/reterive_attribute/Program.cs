using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name) => Name = name;
}

[Author("John Doe")]
class SampleClass { }

class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);
        object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);
        if (attributes.Length > 0)
        {
            AuthorAttribute author = (AuthorAttribute)attributes[0];
            Console.WriteLine("Author: " + author.Name);
        }
    }
}
